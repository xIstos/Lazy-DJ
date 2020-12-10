using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Classes
{
    class Category : ICategory
    {
        static Category()
        {
            StaticId = 0;
        }
        public Category(int quantity, ICategoryFolder categoryFolder)
        {
            Id = StaticId++;
            Quantity = quantity;
            Base = categoryFolder;
        }
        private static int StaticId { get; set; }
        public int Id { get;set; }
        public int Quantity { get; set; }
        public ICategoryFolder Base { get; set; }
    }
}

