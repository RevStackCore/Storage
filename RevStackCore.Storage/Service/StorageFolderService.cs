using System;
using RevStackCore.Storage.Model;
using RevStackCore.Storage.Repository;

namespace RevStackCore.Storage.Service
{
    public class StorageFolderService : IStorageFolderService
    {
        private readonly IStorageFolderRepository _storageFolderRepository;
        private readonly IFolderRepository _folderRepository;

        public StorageFolderService(IStorageFolderRepository storageFolderRepository, IFolderRepository folderRepository)
        {
            _storageFolderRepository = storageFolderRepository;
            _folderRepository = folderRepository;
        }

        public IStorageFolder Add(string path)
        {
            try
            {
                IFolder folder = _folderRepository.Add(path);
                IStorageFolder storageFolder = new StorageFolder();
                storageFolder.Path = path;
                storageFolder = _storageFolderRepository.Add(storageFolder);

                return storageFolder;
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
                IStorageFolder storageFolder = this.Get(id);
                _folderRepository.Delete(storageFolder.Path);
                _storageFolderRepository.Delete(storageFolder);
            }
            catch (Exception ex)
            {
                ex.Data.Add(0, ex.Message);
                throw ex;
            }
        }

        public IStorageFolder Get(int id)
        {
            return _storageFolderRepository.Get(id);
        }

        public IStorageFolder Update(int id, string path)
        {
            try
            {
                IStorageFolder storageFolder = this.Get(id);
                _folderRepository.Update(storageFolder.Path, path);
                storageFolder.Path = path;
                _storageFolderRepository.Update(storageFolder);

                return storageFolder;
            }
            catch (Exception ex)
            {
                ex.Data.Add(0, ex.Message);
                throw ex;
            }
        }
    }
}
