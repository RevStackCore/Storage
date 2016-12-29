using System;
using System.Collections.Generic;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Repository
{
    public interface IStorageFileRepository
    {
        IStorageFile Add(IStorageFile entity);
        void Delete(IStorageFile entity);
        IEnumerable<IStorageFile> Get();
        IStorageFile Get(int id);
        IStorageFile Update(IStorageFile entity);
    }
}
