using System;

namespace RevStackCore.Storage.Model
{
    public interface IFolder
    {
        string Path { get; set; }
        string Url { get; set; }
        long Size { get; set; }
    }
}
