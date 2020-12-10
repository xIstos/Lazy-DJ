using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Common
{
    static class FormatsFilter
    {
        static FormatsFilter()
        {
            DefineFormats();
        }

        public static List<string> Formats { get; private set; }
        private static void DefineFormats()
        {
            Formats = new List<string>() {".AC3", ".FLAC", ".M4A",
                                            ".MP2", ".MP3", ".MP4", ".OGG",
                                            ".OPUS", ".WAV", ".WMA", ".MKA"};
        }
        
    }
}
