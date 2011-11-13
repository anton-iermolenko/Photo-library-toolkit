using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoLibaryToolkit.Framework
{
    using System.IO;
    using MediaInfoLib;

    class VideoMiner : MediaMinerBase
    {
        public VideoMiner(string path, bool scanSubfolders, ISimpleLogger logger)
            : base(path, scanSubfolders, logger)
        {
        }

        protected override string[] GetFolderSearchPatternsList()
        {
            return new [] {"*.3gp", "*.mov", "*.mp4", "*.avi"};
        }

        protected override DateTime GetTakenDate(string filePath)
        {
            if (Path.GetExtension(filePath).ToLower() == ".mov")
            {
                MediaInfo mediaInfo = null;
                try
                {
                    mediaInfo = new MediaInfo();
                    mediaInfo.Open(filePath);

                    string recordedDate = mediaInfo.Get(StreamKind.General, 0, "Recorded_Date");
                    if (string.IsNullOrEmpty(recordedDate))
                    {
                        recordedDate = mediaInfo.Get(StreamKind.General, 0, "Encoded_Date");
                        recordedDate = recordedDate.Replace("UTC ", string.Empty) + "Z";
                    }
                    return DateTime.Parse(recordedDate);
                }
                catch (Exception)
                {

                }
                finally
                {
                    if (mediaInfo != null)
                    {
                        mediaInfo.Close();
                    }
                }
            }
            return base.GetTakenDate(filePath);
        }
    }
}
