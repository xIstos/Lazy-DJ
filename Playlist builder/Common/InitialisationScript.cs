using Playlist_builder.Classes;
using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Common
{
    public class InitialisationScript
    {
        public static void Start()
        {
            SmartFactoryDI.AddObjectRelation<IFileInfoMediaHelper, FileInfoMediaHelper>();
            SmartFactoryDI.AddObjectRelation<ICategory, Category>();
            SmartFactoryDI.AddObjectRelation<ICategoryFolder, CategoryFolder>();
            SmartFactoryDI.AddObjectRelation<IPlaylistGenerator, PlaylistGenerator>();

            SmartFactoryDI.AddSingletone<IUILogicHelper>(new UILogicHelper());
        }
    }
}
