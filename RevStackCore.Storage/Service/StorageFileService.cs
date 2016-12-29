using System;
using System.IO;
using RevStackCore.Storage.Model;
using RevStackCore.Storage.Repository;

namespace RevStackCore.Storage.Service
{
    public class StorageFileService : IStorageFileService
    {
        private readonly IStorageFileRepository _storageFileRepository;
        private readonly IFileRepository _fileRepository;

        public StorageFileService(IStorageFileRepository storageFileRepository, IFileRepository fileRepository)
        {
            _storageFileRepository = storageFileRepository;
            _fileRepository = fileRepository;
        }

        public IStorageFile Add(string path, Stream stream)
        {
            try
            {
                byte[] byteArray;

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    byteArray = ms.ToArray();
                }

                Model.IFile file = _fileRepository.Add(byteArray, path);
                IStorageFile storageFile = new StorageFile();
                storageFile.Path = path;
                storageFile = _storageFileRepository.Add(storageFile);

                return storageFile;
            }
            catch (Exception ex)
            {
                ex.Data.Add(0, ex.Message);
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                IStorageFile storageFile = _storageFileRepository.Get(id);
                _fileRepository.Delete(storageFile.Path);
                _storageFileRepository.Delete(storageFile);
            }
            catch (Exception ex)
            {
                ex.Data.Add(0, ex.Message);
                throw ex;
            }
        }

        public IStorageFile Get(int id)
        {
            return _storageFileRepository.Get(id);
        }

        public IStorageFile Update(int id, string path, Stream stream)
        {
            try
            {
                byte[] byteArray;

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    byteArray = ms.ToArray();
                }

                IStorageFile storageFile = _storageFileRepository.Get(id);
                Model.IFile file = _fileRepository.Update(byteArray, storageFile.Path, path);
                storageFile.Path = path;
                storageFile = _storageFileRepository.Update(storageFile);

                return storageFile;
            }
            catch (Exception ex)
            {
                ex.Data.Add(0, ex.Message);
                throw ex;
            }
        }
    }
}
