using System;
using System.Collections.Generic;
using Playlist_builder.Interfaces;

namespace Playlist_builder.Interfaces
{
    interface IPlaylistGenerator
    {
        List<string> NewNamesList { get; }
        List<IFileInfoMediaHelper> PlayList { get; }

        ICategory PrepareData(List<ICategory> categories, TimeSpan duration);
        void GeneratePlaylist();
    }
}