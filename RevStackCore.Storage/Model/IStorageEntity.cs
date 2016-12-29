using System;
using RevStackCore.Pattern;

namespace RevStackCore.Storage.Model
{
    public interface IStorageEntity : IEntity<int>
    {
        string Path { get; set; }
    }
}
