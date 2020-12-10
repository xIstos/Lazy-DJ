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
        private FileInfo _fileInfo;
        public FileInfo FileInfo { get => _fileInfo; set => _fileInfo = value; }

        private TimeSpan _duration;
        public TimeSpan Duration { get => _duration; set => _duration = value; }
    }
}
