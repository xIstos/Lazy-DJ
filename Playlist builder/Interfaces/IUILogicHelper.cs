using System.Collections.Generic;
using Playlist_builder.Interfaces;

namespace Playlist_builder.Interfaces
{
    interface IUILogicHelper
    {
        ICategory AddNewCategory(string path);
        void DeleteCategory(int id);
        List<ICategory> GetAllCategories();
        List<ICategoryFolder> GetAllFolders();
        ICategory GetCategoryBuID(int id);
        void PrepareFolderToNewGeneration();
        void SwapCategoriesID(int firstID, int secondID);
    }
}