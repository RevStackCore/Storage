using System;

namespace RevStackCore.Storage.Model
{
    public class StorageFile : IStorageFile
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }
}
