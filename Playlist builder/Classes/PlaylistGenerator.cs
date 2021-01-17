using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Playlist_builder.Classes
{
    class PlaylistGenerator : IPlaylistGenerator
    {
        public PlaylistGenerator()
        {
            CurrentDuration = new TimeSpan();
            PlayList = new List<IFileInfoMediaHelper>();
            NewNamesList = new List<string>();
        }

        private const string outputFolderName = "Playlist";


        private TimeSpan CurrentDuration { get; set; }
        public List<IFileInfoMediaHelper> PlayList { get; private set; }
        public List<string> NewNamesList { get; private set; }

        public void Generate(List<ICategory> categories, TimeSpan duration)
        {
            PrepareData(categories, duration);
        }
        private void PrepareData(List<ICategory> categories, TimeSpan duration)
        {
            FilterSongsByDuration(categories);

            categories = categories.OrderByDescending(x => x.Id).ToList();

            //Playlist generation
            while (duration.TotalSeconds == 0 || CurrentDuration < duration)
            {
                foreach (var category in categories)
                {
                    if (CurrentDuration > duration && duration.TotalSeconds != 0) break;
                    var counter = category.Quantity;
                    while (counter > 0)
                    {
                        if (CurrentDuration > duration && duration.TotalSeconds != 0) break;
                        try
                        {
                            var song = category.Base.GetNextSong();
                            if (song != null)
                            {
                                PlayList.Add(song);
                                NewNamesList.Add("[" + category.Base.Name + "] " + song.FileInfo.Name);
                                CurrentDuration = CurrentDuration.Add(song.Duration);
                            }
                            else
                            {
                                if (duration.TotalSeconds != 0)
                                {
                                    var result = ShowDurationWarningMessage(category.Base.Name);
                                    if (!result)
                                        return;
                                }
                                GeneratePlaylist();
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            ShowGenerationErrorMessage();
                        }
                        counter--;
                    }
                }
            }
            GeneratePlaylist();
        }
        private void GeneratePlaylist()
        {
            NumberSongs();
            var folderPath = CreateFolder().FullName;
            for (var i = 0; i < PlayList.Count; i++)
            {
                var newFilePath = folderPath + @"\" + NewNamesList[i];
                File.Copy(PlayList[i].FileInfo.FullName, newFilePath);
            }
            Process.Start("explorer.exe", @folderPath);
        }
        private void FilterSongsByDuration(List<ICategory> categories)
        {
            var songsForDeleting = new List<IFileInfoMediaHelper>();

            foreach (var category in categories)
            {
                foreach (var song in category.Base.Files)
                {
                    var vDuration = GetDuration(@song.FileInfo.FullName);
                    song.Duration = vDuration;
                    if ((category.Base.MinDuration >= vDuration && category.Base.MinDuration.TotalSeconds != 0)
                        || (category.Base.MaxDuration <= vDuration && category.Base.MaxDuration.TotalSeconds != 0))
                    {
                        songsForDeleting.Add(song);
                    }
                }
                foreach (var delSong in songsForDeleting)
                {
                    category.Base.Files.Remove(delSong);
                }
            }

        }
        private DirectoryInfo CreateFolder()
        {
            var dateTime = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
            dateTime = dateTime.Replace(":", ".");
            if (System.IO.Directory.Exists(outputFolderName + " " + dateTime))
            {
                dateTime = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();
                dateTime = dateTime.Replace(":", ".");
            }
            DirectoryInfo di = Directory.CreateDirectory(outputFolderName + " " + dateTime);
            return di;
        }
        private void NumberSongs()
        {
            var digitsQuantity = GetDigitsQuantity(NewNamesList.Count);
            digitsQuantity--;
            string zerosBeforeNumber = "";
            int devider = 10;
            for (var i = 0; i < digitsQuantity; i++)
            {
                zerosBeforeNumber += "0";
            }
            for (var i = 0; i < NewNamesList.Count; i++)
            {
                if ((i + 1) / devider == 1)
                {
                    devider *= 10;
                    zerosBeforeNumber = zerosBeforeNumber.Remove(0, 1);
                }
                NewNamesList[i] = zerosBeforeNumber + (i + 1).ToString() + " " + NewNamesList[i];
            }
        }
        private int GetDigitsQuantity(int number)
        {
            int[] sizeTable = { 9, 99, 999, 9999, 99999, 999999, 9999999,
                                  99999999, 999999999, Int32.MaxValue };

            // Requires positive x
            for (int i = 0; ; i++)
                if (number <= sizeTable[i])
                    return i + 1;
        }
        private void ShowGenerationErrorMessage()
        {
            MessageBox.Show(
                    "Oops, there is some problem with playlist generation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
        private bool ShowDurationWarningMessage(string category)
        {
            DialogResult result = MessageBox.Show(
                    "There are not enough songs in: \n" + @"--> " + category + @" <--" + "\n \n" + "Create playlist anyway?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                return true;

            return false;
        }
        private TimeSpan GetDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }
    }
}
