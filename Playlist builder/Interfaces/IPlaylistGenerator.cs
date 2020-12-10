using System;
using System.Collections.Generic;
using Playlist_builder.Interfaces;

namespace Playlist_builder.Interfaces
{
    interface IPlaylistGenerator
    {
        List<string> NewNamesList { get; }
        List<IFileInfoMediaHelper> PlayList { get; }

        void Generate(List<ICategory> categories, TimeSpan duration);
    }
}