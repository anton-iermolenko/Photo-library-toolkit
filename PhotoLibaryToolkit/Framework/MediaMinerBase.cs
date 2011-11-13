namespace PhotoLibaryToolkit.Framework
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using Properties;

    internal abstract class MediaMinerBase : IMediaMiner {
        private string m_path;
        private bool m_scanSubfolders;
        private readonly ISimpleLogger m_logger;

        private int m_totalItemsInProcess;
        private int m_currentProgress;


        public MediaMinerBase(string path, bool scanSubfolders, ISimpleLogger logger)
        {
            m_path = path;
            m_scanSubfolders = scanSubfolders;
            m_logger = logger;
        }

        public Dictionary<string, DateTime> GetMediaFilesList()
        {
            var searchOption = m_scanSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var result = new Dictionary<string, DateTime>();

            foreach (var searchPattern in GetFolderSearchPatternsList())
            {
                var filesList = Directory.GetFiles(m_path, searchPattern, searchOption);
                m_totalItemsInProcess = filesList.Length;
                m_currentProgress = 0;
                m_logger.LogFormat(Resources.MediaMinerBase_GetMediaFilesList_Found__0__with__1__extension, m_totalItemsInProcess, searchPattern);

                Dictionary<string, DateTime> interimResult = filesList.AsParallel()
                    .Select(p => new { File = p, TakenDate = GetTakenDateEntry(p) })
                    .Where(p => p.TakenDate != null).ToDictionary(p => p.File, p => p.TakenDate.Value);

                result = result.Concat(interimResult).ToDictionary(p => p.Key, p => p.Value);
            }

            return result;
        }

        protected abstract string[] GetFolderSearchPatternsList();

        private DateTime? GetTakenDateEntry(string filePath)
        {
            try
            {
                DateTime result = GetTakenDate(filePath);

                int currentValue = Interlocked.Increment(ref m_currentProgress);
                if (currentValue % 50 == 0)
                {
                    m_logger.LogFormat(Resources.MediaMinerBase_GetTakenDateEntry_Processed__0___1_, currentValue, m_totalItemsInProcess);
                }

                return result;
            }
            catch (Exception ex)
            {
                m_logger.LogFormat(Resources.MediaMinerBase_GetTakenDateEntry_Cannot_get_date_from__0___Error___1_, filePath, ex);
                return null;
            }
        }

        protected virtual DateTime GetTakenDate(string filePath)
        {
            DateTime[] dates = new[]
            {
                File.GetCreationTime(filePath), 
                File.GetLastWriteTime(filePath)
            };

            return dates.Min();
        }
    }
}