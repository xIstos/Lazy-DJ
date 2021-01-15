using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Classes
{
    class FileInfoMediaHelper : IFileInfoMediaHelper
    {
        public FileInfoMediaHelper()
        {
            Duration = new TimeSpan();
        }
        public FileInfo FileInfo { get; set; }
        public TimeSpan Duration { get; set; }        
    }
}
