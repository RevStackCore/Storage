using System;
using System.Collections.Generic;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Repository
{
    public interface IStorageFolderRepository
    {
        IStorageFolder Add(IStorageFolder entity);
        void Delete(IStorageFolder entity);
        IEnumerable<IStorageFolder> Get();
        IStorageFolder Get(int id);
        IStorageFolder Update(IStorageFolder entity);
    }
}
