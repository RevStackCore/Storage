using System;
using System.IO;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Service
{
    public interface IStorageFileService
    {
        IStorageFile Add(string path, Stream stream);
        IStorageFile Update(int id, string path, Stream stream);
        IStorageFile Get(int id);
        void Delete(int id);
    }
}
