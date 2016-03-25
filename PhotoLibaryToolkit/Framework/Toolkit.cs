using System.Windows.Forms.VisualStyles;

namespace PhotoLibaryToolkit.Framework
{
    using System.IO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PFP.Imaging;
    using Properties;

    public class Toolkit
    {
        private readonly ISimpleLogger m_logger;

        public Toolkit(ISimpleLogger loggingDevice)
        {
            m_logger = loggingDevice;
        }

        public void CloneModificationDates(string sourcePath, string sourceExtension, string targetPath, string targetExtension)
        {
            try
            {
                var originalFiles = Directory.GetFiles(sourcePath, string.Format("*.{0}", sourceExtension));
                m_logger.LogFormat(Resources.Toolkit_CloneModificationDates_Found__0__files, originalFiles.Length);

                int numberOfItemsModified = 0;
                var videoExtensions = VideoInfo.GetVideoExtensions();
                var imageExtensions = ImageInfo.GetImageExtensions();

                foreach (var originalFile in originalFiles)
                {
                    var originalFileName = Path.GetFileNameWithoutExtension(originalFile);
                    var convertedFilePath = string.Format("{0}.{1}", Path.Combine(targetPath, originalFileName), targetExtension);
                    if (File.Exists(convertedFilePath))
                    {
                        DateTime? originalFileDate = null;
                        var originalFileExtension = "*" + Path.GetExtension(originalFile).ToLower();
                        
                        if (videoExtensions.Contains(originalFileExtension))
                        {
                            originalFileDate = VideoInfo.GetVideoFileTakenDate(originalFile);
                        }
                        else if (imageExtensions.Contains(originalFileExtension))
                        {
                            originalFileDate = ImageInfo.GetTakenDate(originalFile);
                        }

                        if (originalFileDate == null)
                        {
                            originalFileDate = new[] {File.GetLastWriteTime(originalFile), File.GetCreationTime(originalFile)}.Min();
                        }

                        
                        m_logger.LogFormat(Resources.Toolkit_CloneModificationDates_Updating__0__from__1__to__2_, originalFileName, File.GetLastWriteTime(convertedFilePath), originalFileDate);
                        File.SetCreationTime(convertedFilePath, originalFileDate.Value);
                        File.SetLastWriteTime(convertedFilePath, originalFileDate.Value);

                        numberOfItemsModified++;
                    }
                }

                m_logger.LogFormat(Resources.Toolkit_CloneModificationDates_Modified__0__files, numberOfItemsModified);
            }
            catch (Exception ex)
            {
                m_logger.LogFormat(Resources.Toolkit_CloneModificationDates_Error___0_, ex);
            }
        }

        public void OrganizePhotoLibrary(string path, bool reviewBeforeApply, bool scanSubfolders, bool refreshDatesForAllFiles, Func<PhotoLibraryMap, bool> reviewFunction)
        {
            try
            {
                Dictionary<string, DateTime> minedPhotoData = new PhotoMiner(path, scanSubfolders, m_logger).GetMediaFilesList();
                m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Loaded_info_for__0__photos, minedPhotoData.Count);

                Dictionary<string, DateTime> minedVideoData = new VideoMiner(path, scanSubfolders, m_logger).GetMediaFilesList();
                m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Loaded_info_for__0__videos, minedVideoData.Count);

                var libraryDataSet = new PhotoLibraryMap();
                foreach (var file in minedPhotoData.Concat(minedVideoData))
                {
                    var row = libraryDataSet.RenamingQueue.NewRenamingQueueRow();

                    row.CurrentFileName = Path.GetFileNameWithoutExtension(file.Key);
                    row.NewFileName = string.Format("ML{0}", file.Value.ToString("yyyyMMdd_HHmmss"));
                    row.Extension = Path.GetExtension(file.Key).ToLower();
                    row.FileLocation = file.Key;
                    row.TakenDate = file.Value;
                    row.RenameFlag = row.CurrentFileName != row.NewFileName;
                    row.IsPhoto = minedPhotoData.ContainsKey(file.Key);

                    libraryDataSet.RenamingQueue.AddRenamingQueueRow(row);
                }

                var duplicateNewFiles = libraryDataSet.RenamingQueue.GroupBy(p => new {p.TakenDate, p.Extension}).Where(x => x.Count() > 1).ToList();
                if (duplicateNewFiles.Count > 0)
                {
                    m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Creating_unique_file_names_for__0__duplicates, minedVideoData.Count);
                    foreach (var duplicateNewFilesGroup in duplicateNewFiles)
                    {
                        int duplicateIndex = 1;
                        foreach (var row in duplicateNewFilesGroup.OrderBy(p => p.CurrentFileName))
                        {
                            row.DuplicateFlag = true;
                            row.NewFileName = string.Format("{0}_{1}", row.NewFileName, duplicateIndex++);
                            row.RenameFlag = row.CurrentFileName != row.NewFileName;
                        }
                    }
                }

                // Ensure linked files (same name, but different extension) get renamed as well

                var allLinkedFiles = Directory
                    .GetFiles(path, "*", scanSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                    .GroupBy(p => Path.Combine(Path.GetDirectoryName(p), Path.GetFileNameWithoutExtension(p)))
                    .ToDictionary(g => g.Key, g => g.Select(p => new { FileName = Path.GetFileName(p), Path = p }).ToList());
                
                foreach (var linkedFilesInQueue in libraryDataSet.RenamingQueue.GroupBy(p => Path.Combine(Path.GetDirectoryName(p.FileLocation), Path.GetFileNameWithoutExtension(p.FileLocation))))
                {
                    var otherLinkedFiles = allLinkedFiles[linkedFilesInQueue.Key]
                        .Where(p => linkedFilesInQueue.All(lf => lf.FileLocation != p.Path))
                        .ToList();
                    var jointLinkedFiles = linkedFilesInQueue.ToList();
                    var fileNameProto = linkedFilesInQueue.OrderBy(p => p.IsPhoto).First();

                    if (otherLinkedFiles.Count > 0)
                    {
                        // Create renaming records for newly recognized linked files
                        foreach (var otherLinkedFile in otherLinkedFiles)
                        {
                            var row = libraryDataSet.RenamingQueue.NewRenamingQueueRow();

                            row.CurrentFileName = Path.GetFileNameWithoutExtension(otherLinkedFile.Path);
                            row.Extension = Path.GetExtension(otherLinkedFile.Path).ToLower();
                            row.FileLocation = otherLinkedFile.Path;
                            row.TakenDate = new[]
                            {
                                File.GetCreationTime(otherLinkedFile.Path),
                                File.GetLastWriteTime(otherLinkedFile.Path)
                            }.Min();
                            row.IsPhoto = false;

                            jointLinkedFiles.Add(row);
                            libraryDataSet.RenamingQueue.AddRenamingQueueRow(row);
                        }
                    }

                    // Align new file names
                    foreach (var jointLinkedFile in jointLinkedFiles)
                    {
                        jointLinkedFile.NewFileName = fileNameProto.NewFileName;
                        // Re-evaluate rename flag
                        jointLinkedFile.RenameFlag = jointLinkedFile.CurrentFileName != jointLinkedFile.NewFileName;
                    }
                }

                if (reviewBeforeApply)
                {
                    bool proceed = reviewFunction.Invoke(libraryDataSet);

                    if (!proceed)
                    {
                        m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Cancelled);
                        return;
                    }
                }

                int renameCounter = 0;
                foreach (var renamingQueueRow in libraryDataSet.RenamingQueue)
                {
                    
                    try
                    {
                        string newFileLocation = Path.Combine(Path.GetDirectoryName(renamingQueueRow.FileLocation), string.Format("{0}{1}", renamingQueueRow.NewFileName, renamingQueueRow.Extension));

                        if (renamingQueueRow.RenameFlag)
                        {
                            File.Move(renamingQueueRow.FileLocation, newFileLocation);
                            File.SetCreationTime(newFileLocation, renamingQueueRow.TakenDate);
                            File.SetLastWriteTime(newFileLocation, renamingQueueRow.TakenDate);
                            renameCounter++;
                        }
                        else if (refreshDatesForAllFiles)
                        {
                            File.SetCreationTime(renamingQueueRow.FileLocation, renamingQueueRow.TakenDate);
                            File.SetLastWriteTime(renamingQueueRow.FileLocation, renamingQueueRow.TakenDate);
                        }
                    }
                    catch (Exception ex)
                    {
                        m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Error_renaming___0_, ex);
                    }
                    
                }

                m_logger.LogFormat(Resources.Toolkit_OrganizePhotoLibrary_Renamed__0__files__skipped__1_, renameCounter, libraryDataSet.RenamingQueue.Count - renameCounter);
            }
            catch (Exception ex)
            {
                m_logger.LogFormat(Resources.Toolkit_CloneModificationDates_Error___0_, ex);
            }
        }
    }
}
