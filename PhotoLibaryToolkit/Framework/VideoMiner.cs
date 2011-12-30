namespace PhotoLibaryToolkit.Framework
{
    using System;

    class VideoMiner : MediaMinerBase
    {
        public VideoMiner(string path, bool scanSubfolders, ISimpleLogger logger)
            : base(path, scanSubfolders, logger)
        {
        }

        protected override string[] GetFolderSearchPatternsList()
        {
            return VideoInfo.GetVideoExtensions();
        }

        protected override DateTime GetTakenDate(string filePath)
        {
            return VideoInfo.GetVideoFileTakenDate(filePath) ?? base.GetTakenDate(filePath);
        }
    }
}
