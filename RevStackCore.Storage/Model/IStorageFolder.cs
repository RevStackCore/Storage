using System;
using System.Collections.Generic;

namespace RevStackCore.Storage.Model
{
    public interface IStorageFolder : IStorageEntity
    {
        List<IStorageFile> Files { get; set; }
        List<IStorageFolder> Folders { get; set; }
    }
}
