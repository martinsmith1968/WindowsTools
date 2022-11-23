using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LogFileWatcher.Interfaces
{

    public delegate void WatchedFileCreated(IWatchedFile watchedFile, int changeType);
    public delegate void WatchedFileChanged(IWatchedFile watchedFile, int changeType);
    public delegate void WatchedFileDeleted(IWatchedFile watchedFile, int changeType);

    public interface IWatchedFile
    {
        string FileName { get; }

        FileInfo Info { get; }

        event WatchedFileCreated OnWatchedFileCreated;

        event WatchedFileChanged OnWatchedFileChanged;

        event WatchedFileDeleted OnWatchedFileDeleted;


    }
}
