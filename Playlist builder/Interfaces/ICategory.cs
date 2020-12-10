using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Interfaces
{
    interface ICategory
    {
        int Id { get; set; }
        int Quantity { get; set; }
        ICategoryFolder Base { get; set; }
    }
}
