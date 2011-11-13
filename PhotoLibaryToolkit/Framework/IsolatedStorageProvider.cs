namespace PhotoLibaryToolkit.Framework
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.IsolatedStorage;
    using System.Linq;
    using System.Runtime.Serialization.Formatters;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    internal class IsolatedStorageProvider<T> : IPersistanceProvider<T>
    {
        private string m_settingsFileName;

        public IsolatedStorageProvider()
        {
            m_settingsFileName = typeof(T).Name;
        }

        #region IPersistanceProvider Members

        public T Load()
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (storage.GetFileNames(m_settingsFileName).Length == 0)
            {
                // File doesn't exist.
                return default(T);
            }

            using (Stream stream = new IsolatedStorageFileStream(m_settingsFileName, FileMode.Open, FileAccess.Read, storage))
            {
                var formatter = new BinaryFormatter { AssemblyFormat = FormatterAssemblyStyle.Simple };
                return (T)formatter.Deserialize(stream);
            }
        }

        public void Save(T userSettings)
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            bool isSerializing = false;
            try
            {
                using (Stream stream = new IsolatedStorageFileStream(m_settingsFileName, FileMode.Create, storage))
                {
                    // Serialize the Hashtable into the IsolatedStorage.
                    var formatter = new BinaryFormatter();
                    isSerializing = true;
                    formatter.Serialize(stream, userSettings);
                }
            }
            catch
            {
                // In case of any errors during serialization delete the file to avoid storing corrupted data
                if (isSerializing)
                {
                    storage.DeleteFile(m_settingsFileName);
                }

                throw;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            // Nothing to dispose
        }

        #endregion
    }
}
