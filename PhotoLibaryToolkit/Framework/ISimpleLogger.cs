using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoLibaryToolkit.Framework
{
    public interface ISimpleLogger
    {
        void LogFormat(string format, params object[] formatParams);
    }
}
