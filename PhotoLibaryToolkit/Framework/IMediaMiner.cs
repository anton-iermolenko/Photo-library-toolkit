using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoLibaryToolkit.Framework
{
    interface IMediaMiner
    {
        Dictionary<string, DateTime> GetMediaFilesList();
    }
}
