using System;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Service
{
    public interface IStorageFolderService
    {
        IStorageFolder Add(string path);
        IStorageFolder Update(int id, string path);
        IStorageFolder Get(int id);
        void Delete(int id);
    }
}
