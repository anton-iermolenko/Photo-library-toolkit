using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoLibaryToolkit.Framework
{
    public class LambdaLogger : ISimpleLogger
    {
        private readonly Action<string> m_loggingImplementation;

        public LambdaLogger(Action<string> loggingImplementation)
        {
            m_loggingImplementation = loggingImplementation;
        }

        public void LogFormat(string format, params object[] formatParams)
        {
            m_loggingImplementation.Invoke(string.Format(format, formatParams));
        }
    }
}
