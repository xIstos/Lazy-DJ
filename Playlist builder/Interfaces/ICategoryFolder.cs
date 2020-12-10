using System;
using System.Collections.Generic;

namespace Playlist_builder.Interfaces
{
    interface ICategoryFolder
    {
        List<ICategory> Categories { get; set; }
        string CategoryPath { get; set; }
        List<IFileInfoMediaHelper> Files { get; set; }
        TimeSpan MaxDuration { get; set; }
        TimeSpan MinDuration { get; set; }
        string Name { get; set; }
        string Sorting { get; set; }

        void DeleteNonPlayebleFiles(List<string> formats);
        IFileInfoMediaHelper GetNextSong();
        void ReadFilesFromFolder();
        void ResetQueueCounter();
        void SortFiles();
    }
}