using System;

namespace RevStackCore.Storage.Model
{
    public interface IFile
    {
        string Name { get; set; }
        string Url { get; set; }
        long Size { get; set; }
    }
}
