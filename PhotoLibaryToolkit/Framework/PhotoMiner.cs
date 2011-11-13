using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoLibaryToolkit.Framework
{
    using System.Drawing;
    using System.Globalization;
    using System.Threading;
    using PFP.Imaging;

    class PhotoMiner : MediaMinerBase
    {
        public PhotoMiner(string path, bool scanSubfolders, ISimpleLogger logger)
            : base(path, scanSubfolders, logger)
        {}

        protected override string[] GetFolderSearchPatternsList()
        {
            return new[] { "*.png", "*.jpg" };
        }

        protected override DateTime GetTakenDate(string file)
        {
            var takenDate = ImageInfo.GetTakenDate(file);
            return takenDate ?? base.GetTakenDate(file);
        }
    }
}
