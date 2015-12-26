
namespace PhotoLibaryToolkit.Framework
{
    using System;
    using System.Globalization;
    using MediaInfoLib;

    class VideoInfo
    {
        public static string[] GetVideoExtensions()
        {
            return new [] {"*.3gp", "*.mov", "*.mp4", "*.avi"};
        }

        public static DateTime? GetVideoFileTakenDate(string filePath)
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
                        var dateTimeStyles = DateTimeStyles.AssumeUniversal;
                        // Canon records local time as UTC
                        var canonCameraIdentifier = mediaInfo.Get(StreamKind.General, 0, "CodecID/String");
                        if (canonCameraIdentifier.Contains("/CAEP"))
                        {
                            dateTimeStyles = DateTimeStyles.AssumeLocal;
                        }

                        result = DateTime.ParseExact(recordedDate, "\"UTC\" yyyy-MM-dd HH:mm:ss",
                            CultureInfo.InvariantCulture, dateTimeStyles);
                    }
                }

                if (result == null)
                {
                    recordedDate = mediaInfo.Get(StreamKind.General, 0, "Mastered_Date");
                    if (!string.IsNullOrWhiteSpace(recordedDate))
                    {
                        result = DateTime.ParseExact(recordedDate, "ddd MMM dd HH:mm:ss yyyy",
                            CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
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
            return null;
        }
    }
}
