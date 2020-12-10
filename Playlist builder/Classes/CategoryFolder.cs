
using Playlist_builder.Common;
using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Playlist_builder.Classes
{
    class CategoryFolder : ICategoryFolder
    {
        public CategoryFolder(string path)
        {
            Categories = new List<ICategory>();
            Files = new List<IFileInfoMediaHelper>();
            Sorting = SortEnum.random.ToString();
            CategoryPath = path;
            SetNameFromPath();
        }
        private static Random rnd = new Random();

        private int counter = 0;
        public string Name { get; set; }
        public string CategoryPath { get; set; }
        public string Sorting { get; set; }
        public TimeSpan MinDuration { get; set; }
        public TimeSpan MaxDuration { get; set; }
        public List<ICategory> Categories { get; set; }
        public List<IFileInfoMediaHelper> Files { get; set; }
        public void DeleteNonPlayebleFiles(List<string> formats)
        {
            List<IFileInfoMediaHelper> sortedFiles = new List<IFileInfoMediaHelper>();
            foreach (var file in Files)
            {
                foreach (var format in formats)
                {
                    if (file.FileInfo.Extension.ToUpper().Equals(format))
                    {
                        sortedFiles.Add(file);
                        break;
                    }
                }
            }
            Files = sortedFiles;
        }
        public void ResetQueueCounter()
        {
            counter = 0;
        }
        public IFileInfoMediaHelper GetNextSong()
        {
            if (Files.Count >= counter + 1)
            {
                return Files[counter++];
            }
            return null;
        }
        private void SetNameFromPath()
        {
            Name = Path.GetFileName(CategoryPath);
        }
        public void ReadFilesFromFolder()
        {
            var files = new DirectoryInfo(@CategoryPath).GetFiles().ToList();
            foreach (var file in files)
            {
                var fileInfoMediaHelper = SmartFactoryDI.GetInstance<IFileInfoMediaHelper>();
                fileInfoMediaHelper.FileInfo = file;
                Files.Add(fileInfoMediaHelper);
            }
        }
        public void SortFiles()
        {
            if (Sorting == "name")
            {
                Files.OrderBy(x => x.FileInfo.Name);
            }
            else if (Sorting == "creation")
            {
                Files.OrderBy(f => f.FileInfo.CreationTime);
            }
            else
            {
                Shuffle(Files);
            }
        }
        private static void Shuffle(List<IFileInfoMediaHelper> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                IFileInfoMediaHelper value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
