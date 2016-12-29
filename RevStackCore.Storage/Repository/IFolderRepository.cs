using System;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Repository
{
    public interface IFolderRepository
    {
        IFolder Get(string path);
        IFolder Add(string path);
        IFolder Update(string path, string destination);
        void Delete(string path);
    }
}
