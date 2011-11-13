namespace PhotoLibaryToolkit.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal interface IPersistanceProvider<T> : IDisposable
    {
        T Load();

        void Save(T settings);
    }
}
