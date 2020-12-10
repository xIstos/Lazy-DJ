using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Interfaces
{
    interface IFileInfoMediaHelper
    {
        FileInfo FileInfo { get; set; }
        TimeSpan Duration { get; set; }
    }
}
