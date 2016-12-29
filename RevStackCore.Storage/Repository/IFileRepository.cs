using System;
using RevStackCore.Storage.Model;

namespace RevStackCore.Storage.Repository
{
    public interface IFileRepository
    {
        IFile Add(byte[] byteArray, string path);
        IFile Update(byte[] byteArray, string path, string destination);
        void Delete(string path);
        IFile Get(string path);
    }
}
