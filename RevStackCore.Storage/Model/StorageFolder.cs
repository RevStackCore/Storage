using System;
using System.Collections.Generic;

namespace RevStackCore.Storage.Model
{
    public class StorageFolder : IStorageFolder
    {
        public StorageFolder()
        {
            Files = new List<IStorageFile>();
            Folders = new List<IStorageFolder>();
        }

        public List<IStorageFile> Files { get; set; }
        public List<IStorageFolder> Folders { get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
    }
}
