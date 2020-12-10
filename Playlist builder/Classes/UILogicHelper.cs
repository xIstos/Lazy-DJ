using Playlist_builder.Common;
using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist_builder.Classes
{
    class UILogicHelper : IUILogicHelper
    {

        private List<ICategoryFolder> categoriesFolders = new List<ICategoryFolder>();
        private List<ICategory> categories = new List<ICategory>();

        public ICategory GetCategoryBuID(int id)
        {
            return categories.Find(item => item.Id == id);
        }
        public List<ICategoryFolder> GetAllFolders()
        {
            return categoriesFolders;
        }
        public List<ICategory> GetAllCategories()
        {
            return categories;
        }
        public ICategory AddNewCategory(string path)
        {
            var categoryFolder = categoriesFolders.Find(item => item.CategoryPath == path);
            if (categories.Count != 0 && categoryFolder != null)
            {
                var newCategory = SmartFactoryDI.GetInstance<ICategory>(2, categoryFolder);
                categories.Add(newCategory);
                categoryFolder.Categories.Add(newCategory);
                return newCategory;
            }
            else
            {
                var newCategoryFolder = SmartFactoryDI.GetInstance<ICategoryFolder>(path);
                var newCategory = SmartFactoryDI.GetInstance<ICategory>(2, newCategoryFolder);
                categoriesFolders.Add(newCategoryFolder);
                categories.Add(newCategory);
                newCategoryFolder.Categories.Add(newCategory);
                return newCategory;
            }
        }
        public void DeleteCategory(int id)
        {
            var cat = categories.Find(x => x.Id == id);

            if (cat.Base.Categories.Count == 1)
                categoriesFolders.Remove(cat.Base);
            else
                cat.Base.Categories.Remove(cat);

            categories.Remove(cat);
        }
        public void PrepareFolderToNewGeneration()
        {
            //Folders preparation
            foreach (var folder in categoriesFolders)
            {
                folder.Files.Clear();
                folder.ResetQueueCounter();
                folder.ReadFilesFromFolder();
                folder.SortFiles();
                folder.DeleteNonPlayebleFiles(FormatsFilter.Formats);
            }
        }
        public void SwapCategoriesID(int firstID, int secondID)
        {
            var selectedCategory = categories.Find(x => x.Id == firstID);
            var tempCategory = selectedCategory.Id;
            var secondCategory = categories.Find(x => x.Id == secondID);
            selectedCategory.Id = secondCategory.Id;
            secondCategory.Id = tempCategory;
        }
    }
}
