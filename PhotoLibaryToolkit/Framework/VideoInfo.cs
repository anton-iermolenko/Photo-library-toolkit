namespace PhotoLibaryToolkit.Framework
{
    using System;
    using System.Globalization;
    using System.IO;
    using MediaInfoLib;

    class VideoInfo
    {
        public static string[] GetVideoExtensions()
        {
            return new [] {"*.3gp", "*.mov", "*.mp4", "*.avi"};
        }

        public static DateTime? GetVideoFileTakenDate(string filePath)
        {
            var extension = Path.GetExtension(filePath).ToLower();
            if (extension == ".mov" || extension == ".avi")
            {
                MediaInfo mediaInfo = null;
                try
                {
                    mediaInfo = new MediaInfo();
                    mediaInfo.Open(filePath);

                    DateTime? result = null;
                    string recordedDate = mediaInfo.Get(StreamKind.General, 0, "Recorded_Date");
                    if (!string.IsNullOrWhiteSpace(recordedDate))
                    {
                        result = DateTime.Parse(recordedDate, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    }

                    if (result == null)
                    {
                        recordedDate = mediaInfo.Get(StreamKind.General, 0, "Encoded_Date");
                        if (string.IsNullOrWhiteSpace(recordedDate))
                        {
                            recordedDate = mediaInfo.Get(StreamKind.General, 0, "Tagged_Date");
                        }
                        if (!string.IsNullOrWhiteSpace(recordedDate))
                        {
                            // NOTE: that's specifically for the camera I use
                            result = DateTime.ParseExact(recordedDate, "\"UTC\" yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                        }
                    }

                    if (result == null)
                    {
                        recordedDate = mediaInfo.Get(StreamKind.General, 0, "Mastered_Date");
                        if (!string.IsNullOrWhiteSpace(recordedDate))
                        {
                            result = DateTime.ParseExact(recordedDate, "ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                        }
                    }
                    return result;
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
            return null;
        }
    }
}
