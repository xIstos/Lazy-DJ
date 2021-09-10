using Playlist_builder.Classes;
using Playlist_builder.Common;
using Playlist_builder.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Playlist_builder
{
    enum RowDirectionEnum
    {
        up = -1,
        down = 1
    }
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sortByComboBox.DataSource = Enum.GetValues(typeof(SortEnum));
        }

        private const int minuteInSeconds = 60;

        string browserDialogStartLocaton;
        private bool enableElementHelper = false;
        private bool isDataGridViewInStartState = false;
        private IUILogicHelper logicHelper = SmartFactoryDI.GetSingletone<IUILogicHelper>();

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFolderBrowser();
            AddNewCategory(pathTextBox.Text);
            UpdateOrderButtons();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {            
            var generator = SmartFactoryDI.GetInstance<IPlaylistGenerator>();
            logicHelper.PrepareFolderToNewGeneration();
            TimeSpan duration = new TimeSpan((int)playlistHoursUpDown.Value, (int)playlistMinutesUpDown.Value, 0);

            try
            {
                var category = generator.PrepareData(logicHelper.GetAllCategories(), duration);
                if(category != null)
                {
                    var warningResult = ShowDurationWarningMessage(category.Base.Name);
                    if (warningResult)
                        generator.GeneratePlaylist();
                }
                else
                {
                    generator.GeneratePlaylist();
                }

            }
            catch (Exception)
            {
                ShowGenerationErrorMessage();
            }
            
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int minDuration = (int)minMinutesUpDown.Value * minuteInSeconds + (int)minSecondUpDown.Value;
            int maxDuration = (int)maxMinutesUpDown.Value * minuteInSeconds + (int)maxSecondUpDown.Value;

            //if durations are valid
            if (minDuration == 0 || maxDuration == 0 || maxDuration >= minDuration)
            {
                int id = (int)categoriesDataGridView.Rows[categoriesDataGridView.SelectedRows[0].Index].Cells[5].Value;
                var category = logicHelper.GetCategoryBuID(id);

                category.Base.Name = categoryTextBox.Text;
                category.Base.Sorting = sortByComboBox.SelectedItem.ToString();
                category.Quantity = (int)quantityNumericUpDown.Value;
                category.Base.MinDuration = TimeSpan.FromSeconds(minDuration);
                category.Base.MaxDuration = TimeSpan.FromSeconds(maxDuration);

                //if folder has more then 1 category
                if (category.Base.Categories.Count > 1)
                {
                    foreach (var categ in category.Base.Categories)
                    {
                        // show changes for all related categories
                        DataGridViewRow dgRow = categoriesDataGridView.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => r.Cells[5].Value.ToString().Equals(categ.Id.ToString()))
                            .First();
                        CategoryToRow(categ, dgRow);
                    }
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)categoriesDataGridView.Rows[categoriesDataGridView.CurrentCell.RowIndex];
                    CategoryToRow(category, row);
                }
            }
            else
            {
                var message = "Maximum duration must be more \nthan minimum or equal 0:00(by default). \nOR \nMinimum duration must be equal 0:00(by default).";
                ShowWarningMessage(message);
            }
        }     
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = categoriesDataGridView.SelectedRows[0].Index;
            DeleteCategory(rowIndex);
            UpdateOrderButtons();
        }
        private void UpButton_Click(object sender, EventArgs e)
        {
            MoveRow(RowDirectionEnum.up);
            UpdateOrderButtons();
        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            MoveRow(RowDirectionEnum.down);            
            UpdateOrderButtons();
        }
        private void CategoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if it is last row
            if (categoriesDataGridView.Rows.Count == e.RowIndex + 1 || categoriesDataGridView.CurrentCell.Value == null)
            {
                categoriesDataGridView.ClearSelection();
                EnableInInterfaceElements(false);
            }
            else
            {
                int id = (Int32)categoriesDataGridView.Rows[categoriesDataGridView.CurrentCell.RowIndex].Cells[5].Value;
                var category = logicHelper.GetCategoryBuID(id);
                ShowCategoryValuesInInterfaceElements(category);
                EnableInInterfaceElements(true);
            }
            UpdateOrderButtons();
        }
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            pathIncorrectLabel.Visible = false;
        }
        private void PathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNewCategory(pathTextBox.Text);
                UpdateOrderButtons();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void OpenFolderBrowser()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = false;
            folderDlg.SelectedPath = browserDialogStartLocaton;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathTextBox.Text = folderDlg.SelectedPath;
                browserDialogStartLocaton = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
        private void AddNewCategory(string path)
        {
            if (Directory.Exists(path))
            {
                var newCategory = logicHelper.AddNewCategory(path);
                AddNewRow(newCategory, newCategory.Id);
                pathTextBox.Text = String.Empty;
            }
            else
            {
                pathIncorrectLabel.Visible = true;
            }

        }
        private void DeleteCategory(int rowIndex)
        {
            // if not last row
            if (rowIndex != logicHelper.GetAllCategories().Count)
            {
                DataGridViewRow row = (DataGridViewRow)categoriesDataGridView.Rows[rowIndex];
                var catId = (int)row.Cells[5].Value;
                logicHelper.DeleteCategory(catId);
                categoriesDataGridView.Rows.Remove(row);

                //Change selection focus
                if (logicHelper.GetAllCategories().Count == 0)
                {
                    categoriesDataGridView.ClearSelection();
                    EnableInInterfaceElements(false);
                    isDataGridViewInStartState = false;
                }
                else if (rowIndex != logicHelper.GetAllCategories().Count)
                {
                    categoriesDataGridView.Rows[rowIndex].Selected = true;
                }
            }
        }
        private void AddNewRow(ICategory category, int id)
        {
            if (isDataGridViewInStartState == false)
            {
                categoriesDataGridView.Rows.Add();
                DataGridViewRow row = (DataGridViewRow)categoriesDataGridView.Rows[0];
                CategoryToRow(category, row);
                int dgSelectedId = (Int32)categoriesDataGridView.Rows[0].Cells[5].Value;
                ShowCategoryValuesInInterfaceElements(logicHelper.GetCategoryBuID(dgSelectedId));
                EnableInInterfaceElements(true);
                categoriesDataGridView.Rows[0].Selected = true;
                isDataGridViewInStartState = true;
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)categoriesDataGridView.Rows[categoriesDataGridView.Rows.Count - 1].Clone();
                categoriesDataGridView.Rows.Add(CategoryToRow(category, row));
                categoriesDataGridView.Sort(this.categoriesDataGridView.Columns[5], ListSortDirection.Ascending);
                ShowCategoryValuesInInterfaceElements(logicHelper.GetCategoryBuID(category.Id));
                categoriesDataGridView.CurrentCell = categoriesDataGridView.Rows[categoriesDataGridView.Rows.Count - 2].Cells[0];
                categoriesDataGridView.Rows[categoriesDataGridView.Rows.Count - 2].Selected = true;
            }
        }
        private void ShowCategoryValuesInInterfaceElements(ICategory category)
        {
            categoryTextBox.Text = category.Base.Name;
            Enum.TryParse(category.Base.Sorting, out SortEnum mySort);
            sortByComboBox.SelectedItem = mySort;
            quantityNumericUpDown.Value = category.Quantity;
            minMinutesUpDown.Value = category.Base.MinDuration.Minutes;
            minSecondUpDown.Value = category.Base.MinDuration.Seconds;
            maxMinutesUpDown.Value = category.Base.MaxDuration.Minutes;
            maxSecondUpDown.Value = category.Base.MaxDuration.Seconds;
        }
        private DataGridViewRow CategoryToRow(ICategory category, DataGridViewRow row)
        {
            row.Cells[0].Value = category.Base.Name;
            row.Cells[1].Value = category.Quantity;
            row.Cells[2].Value = category.Base.MaxDuration;
            row.Cells[3].Value = category.Base.MinDuration;
            row.Cells[4].Value = category.Base.Sorting;
            row.Cells[5].Value = category.Id;
            return row;
        }
        private void EnableInInterfaceElements(bool currentStatus)
        {
            if (enableElementHelper != currentStatus)
            {
                categoryTextBox.Enabled = currentStatus;
                sortByComboBox.Enabled = currentStatus;
                quantityNumericUpDown.Enabled = currentStatus;
                minMinutesUpDown.Enabled = currentStatus;
                minSecondUpDown.Enabled = currentStatus;
                maxMinutesUpDown.Enabled = currentStatus;
                maxSecondUpDown.Enabled = currentStatus;
                saveButton.Enabled = currentStatus;
                deleteButton.Enabled = currentStatus;
                generateButton.Enabled = currentStatus;

                enableElementHelper = currentStatus;
            }
        }
        private void ShowWarningMessage(string message)
                {
                    MessageBox.Show(
                            message,
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                }
        private void UpdateOrderButtons()
        {
            try
            {
                if (categoriesDataGridView.SelectedRows[0] != null)
                {
                    var row = categoriesDataGridView.SelectedRows[0];
                    var categories = logicHelper.GetAllCategories();
                    if (categories.Count == 0 || categories.Count == 1)
                    {
                        upButton.Enabled = false;
                        downButton.Enabled = false;
                    }
                    else if (row.Index == 0)
                    {
                        upButton.Enabled = false;
                        downButton.Enabled = true;
                    }
                    else if (row.Index == categories.Count - 1)
                    {
                        upButton.Enabled = true;
                        downButton.Enabled = false;
                    }
                    else
                    {
                        upButton.Enabled = true;
                        downButton.Enabled = true;
                    }
                }
            }
            // when last element deleted from list
            catch (ArgumentOutOfRangeException)
            {
                upButton.Enabled = false;
                downButton.Enabled = false;
            }
        }
        private void MoveRow(RowDirectionEnum direction)
        {
            var selectedRow = categoriesDataGridView.SelectedRows[0];
            var tempSelected = selectedRow.Cells[5].Value;
            var secondRow = categoriesDataGridView.Rows[selectedRow.Index + 1*(int)direction];
            var tempSecond = secondRow.Cells[5].Value;

            //swap rows
            selectedRow.Cells[5].Value = 10000000.ToString();
            secondRow.Cells[5].Value = tempSelected;
            selectedRow.Cells[5].Value = tempSecond;

            logicHelper.SwapCategoriesID((int)tempSelected, (int)tempSecond);

            categoriesDataGridView.Sort(this.categoriesDataGridView.Columns[5], ListSortDirection.Ascending);
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
        private bool ShowDurationWarningMessage(string categoryName)
        {
            DialogResult result = MessageBox.Show(
                    "There are not enough songs in: \n" + @"--> " + categoryName + @" <--" + "\n \n" + "Create playlist anyway?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                return true;

            return false;
        }
    }
}
