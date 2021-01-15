using System;
using System.Drawing;
using System.Windows.Forms;

namespace Playlist_builder
{   
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderPathLable = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.maxDurationLabel = new System.Windows.Forms.Label();
            this.minDurationLabel = new System.Windows.Forms.Label();
            this.maxMinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxMinutesLable = new System.Windows.Forms.Label();
            this.maxSecondLable = new System.Windows.Forms.Label();
            this.maxSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.minSecondLabel = new System.Windows.Forms.Label();
            this.minSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.minMinutesLabel = new System.Windows.Forms.Label();
            this.minMinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.pathIncorrectLabel = new System.Windows.Forms.Label();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.playlistMinLabel = new System.Windows.Forms.Label();
            this.playlistMinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.playlistHoursLabel = new System.Windows.Forms.Label();
            this.playlistHoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.playlistDurationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxMinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistMinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistHoursUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPathLable
            // 
            this.folderPathLable.AutoSize = true;
            this.folderPathLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderPathLable.Location = new System.Drawing.Point(81, 37);
            this.folderPathLable.Name = "folderPathLable";
            this.folderPathLable.Size = new System.Drawing.Size(127, 25);
            this.folderPathLable.TabIndex = 0;
            this.folderPathLable.Text = "Folder path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.Location = new System.Drawing.Point(86, 65);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(730, 31);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            this.pathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathTextBox_KeyDown);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.BackColor = System.Drawing.SystemColors.Window;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(825, 35);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(96, 65);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryTextBox.Enabled = false;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTextBox.Location = new System.Drawing.Point(86, 331);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(307, 28);
            this.categoryTextBox.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(21, 337);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(62, 22);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Name:";
            // 
            // maxDurationLabel
            // 
            this.maxDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxDurationLabel.AutoSize = true;
            this.maxDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxDurationLabel.Location = new System.Drawing.Point(412, 334);
            this.maxDurationLabel.Name = "maxDurationLabel";
            this.maxDurationLabel.Size = new System.Drawing.Size(104, 20);
            this.maxDurationLabel.TabIndex = 6;
            this.maxDurationLabel.Text = "Max duration:";
            // 
            // minDurationLabel
            // 
            this.minDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minDurationLabel.AutoSize = true;
            this.minDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDurationLabel.Location = new System.Drawing.Point(412, 369);
            this.minDurationLabel.Name = "minDurationLabel";
            this.minDurationLabel.Size = new System.Drawing.Size(100, 20);
            this.minDurationLabel.TabIndex = 7;
            this.minDurationLabel.Text = "Min duration:";
            // 
            // maxMinutesUpDown
            // 
            this.maxMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxMinutesUpDown.Enabled = false;
            this.maxMinutesUpDown.Location = new System.Drawing.Point(525, 331);
            this.maxMinutesUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxMinutesUpDown.Name = "maxMinutesUpDown";
            this.maxMinutesUpDown.Size = new System.Drawing.Size(58, 26);
            this.maxMinutesUpDown.TabIndex = 8;
            this.maxMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maxMinutesLable
            // 
            this.maxMinutesLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxMinutesLable.AutoSize = true;
            this.maxMinutesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxMinutesLable.Location = new System.Drawing.Point(590, 337);
            this.maxMinutesLable.Name = "maxMinutesLable";
            this.maxMinutesLable.Size = new System.Drawing.Size(38, 20);
            this.maxMinutesLable.TabIndex = 10;
            this.maxMinutesLable.Text = "min.";
            // 
            // maxSecondLable
            // 
            this.maxSecondLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxSecondLable.AutoSize = true;
            this.maxSecondLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxSecondLable.Location = new System.Drawing.Point(690, 337);
            this.maxSecondLable.Name = "maxSecondLable";
            this.maxSecondLable.Size = new System.Drawing.Size(38, 20);
            this.maxSecondLable.TabIndex = 12;
            this.maxSecondLable.Text = "sec.";
            // 
            // maxSecondUpDown
            // 
            this.maxSecondUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxSecondUpDown.Enabled = false;
            this.maxSecondUpDown.Location = new System.Drawing.Point(636, 331);
            this.maxSecondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.maxSecondUpDown.Name = "maxSecondUpDown";
            this.maxSecondUpDown.Size = new System.Drawing.Size(48, 26);
            this.maxSecondUpDown.TabIndex = 11;
            this.maxSecondUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minSecondLabel
            // 
            this.minSecondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minSecondLabel.AutoSize = true;
            this.minSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minSecondLabel.Location = new System.Drawing.Point(690, 374);
            this.minSecondLabel.Name = "minSecondLabel";
            this.minSecondLabel.Size = new System.Drawing.Size(38, 20);
            this.minSecondLabel.TabIndex = 16;
            this.minSecondLabel.Text = "sec.";
            // 
            // minSecondUpDown
            // 
            this.minSecondUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minSecondUpDown.Enabled = false;
            this.minSecondUpDown.Location = new System.Drawing.Point(636, 368);
            this.minSecondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minSecondUpDown.Name = "minSecondUpDown";
            this.minSecondUpDown.Size = new System.Drawing.Size(48, 26);
            this.minSecondUpDown.TabIndex = 15;
            this.minSecondUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minMinutesLabel
            // 
            this.minMinutesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minMinutesLabel.AutoSize = true;
            this.minMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minMinutesLabel.Location = new System.Drawing.Point(590, 374);
            this.minMinutesLabel.Name = "minMinutesLabel";
            this.minMinutesLabel.Size = new System.Drawing.Size(38, 20);
            this.minMinutesLabel.TabIndex = 14;
            this.minMinutesLabel.Text = "min.";
            // 
            // minMinutesUpDown
            // 
            this.minMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minMinutesUpDown.Enabled = false;
            this.minMinutesUpDown.Location = new System.Drawing.Point(525, 368);
            this.minMinutesUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minMinutesUpDown.Name = "minMinutesUpDown";
            this.minMinutesUpDown.Size = new System.Drawing.Size(58, 26);
            this.minMinutesUpDown.TabIndex = 13;
            this.minMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantityNumericUpDown.Enabled = false;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(330, 368);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(64, 26);
            this.quantityNumericUpDown.TabIndex = 19;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(254, 369);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 20);
            this.quantityLabel.TabIndex = 18;
            this.quantityLabel.Text = "Quantity:";
            // 
            // pathIncorrectLabel
            // 
            this.pathIncorrectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathIncorrectLabel.AutoSize = true;
            this.pathIncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathIncorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.pathIncorrectLabel.Location = new System.Drawing.Point(620, 37);
            this.pathIncorrectLabel.Name = "pathIncorrectLabel";
            this.pathIncorrectLabel.Size = new System.Drawing.Size(191, 25);
            this.pathIncorrectLabel.TabIndex = 20;
            this.pathIncorrectLabel.Text = "Path is incorrect!";
            this.pathIncorrectLabel.Visible = false;
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToResizeRows = false;
            this.categoriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.Quantity,
            this.MaxDuration,
            this.MinDuration,
            this.SortBy,
            this.Id});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.categoriesDataGridView.EnableHeadersVisualStyles = false;
            this.categoriesDataGridView.Location = new System.Drawing.Point(86, 118);
            this.categoriesDataGridView.MultiSelect = false;
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.categoriesDataGridView.RowHeadersWidth = 25;
            this.categoriesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoriesDataGridView.RowTemplate.Height = 24;
            this.categoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesDataGridView.Size = new System.Drawing.Size(837, 205);
            this.categoriesDataGridView.TabIndex = 21;
            this.categoriesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDataGridView_CellClick);
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.CategoryName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 74;
            // 
            // MaxDuration
            // 
            this.MaxDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.MaxDuration.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaxDuration.HeaderText = "Max duration";
            this.MaxDuration.MinimumWidth = 6;
            this.MaxDuration.Name = "MaxDuration";
            this.MaxDuration.ReadOnly = true;
            this.MaxDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaxDuration.Width = 106;
            // 
            // MinDuration
            // 
            this.MinDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.MinDuration.DefaultCellStyle = dataGridViewCellStyle5;
            this.MinDuration.HeaderText = "Min duration";
            this.MinDuration.MinimumWidth = 6;
            this.MinDuration.Name = "MinDuration";
            this.MinDuration.ReadOnly = true;
            this.MinDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinDuration.Width = 102;
            // 
            // SortBy
            // 
            this.SortBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            this.SortBy.DefaultCellStyle = dataGridViewCellStyle6;
            this.SortBy.HeaderText = "Sort by:";
            this.SortBy.MinimumWidth = 6;
            this.SortBy.Name = "SortBy";
            this.SortBy.ReadOnly = true;
            this.SortBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SortBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SortBy.Width = 69;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(758, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 68);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.BackColor = System.Drawing.SystemColors.Window;
            this.generateButton.Enabled = false;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(758, 409);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(168, 77);
            this.generateButton.TabIndex = 23;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // sortByLabel
            // 
            this.sortByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByLabel.Location = new System.Drawing.Point(21, 375);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(63, 20);
            this.sortByLabel.TabIndex = 25;
            this.sortByLabel.Text = "Sort by:";
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.Enabled = false;
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Location = new System.Drawing.Point(86, 368);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(108, 28);
            this.sortByComboBox.TabIndex = 26;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.SystemColors.Window;
            this.upButton.Enabled = false;
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upButton.Image = ((System.Drawing.Image)(resources.GetObject("upButton.Image")));
            this.upButton.Location = new System.Drawing.Point(33, 118);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(46, 45);
            this.upButton.TabIndex = 29;
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.SystemColors.Window;
            this.downButton.Enabled = false;
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downButton.Image = ((System.Drawing.Image)(resources.GetObject("downButton.Image")));
            this.downButton.Location = new System.Drawing.Point(33, 171);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(46, 45);
            this.downButton.TabIndex = 30;
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(33, 280);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(46, 45);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // playlistMinLabel
            // 
            this.playlistMinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistMinLabel.AutoSize = true;
            this.playlistMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistMinLabel.Location = new System.Drawing.Point(591, 435);
            this.playlistMinLabel.Name = "playlistMinLabel";
            this.playlistMinLabel.Size = new System.Drawing.Size(58, 29);
            this.playlistMinLabel.TabIndex = 36;
            this.playlistMinLabel.Text = "min.";
            // 
            // playlistMinutesUpDown
            // 
            this.playlistMinutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistMinutesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistMinutesUpDown.Location = new System.Drawing.Point(520, 432);
            this.playlistMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.playlistMinutesUpDown.Name = "playlistMinutesUpDown";
            this.playlistMinutesUpDown.Size = new System.Drawing.Size(63, 35);
            this.playlistMinutesUpDown.TabIndex = 35;
            this.playlistMinutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // playlistHoursLabel
            // 
            this.playlistHoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistHoursLabel.AutoSize = true;
            this.playlistHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistHoursLabel.Location = new System.Drawing.Point(489, 435);
            this.playlistHoursLabel.Name = "playlistHoursLabel";
            this.playlistHoursLabel.Size = new System.Drawing.Size(32, 29);
            this.playlistHoursLabel.TabIndex = 34;
            this.playlistHoursLabel.Text = "h.";
            // 
            // playlistHoursUpDown
            // 
            this.playlistHoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistHoursUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistHoursUpDown.Location = new System.Drawing.Point(430, 432);
            this.playlistHoursUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.playlistHoursUpDown.Name = "playlistHoursUpDown";
            this.playlistHoursUpDown.Size = new System.Drawing.Size(58, 35);
            this.playlistHoursUpDown.TabIndex = 33;
            this.playlistHoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // playlistDurationLabel
            // 
            this.playlistDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistDurationLabel.AutoSize = true;
            this.playlistDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistDurationLabel.Location = new System.Drawing.Point(250, 435);
            this.playlistDurationLabel.Name = "playlistDurationLabel";
            this.playlistDurationLabel.Size = new System.Drawing.Size(188, 29);
            this.playlistDurationLabel.TabIndex = 32;
            this.playlistDurationLabel.Text = "Playlist duration:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(939, 502);
            this.Controls.Add(this.playlistMinLabel);
            this.Controls.Add(this.playlistMinutesUpDown);
            this.Controls.Add(this.playlistHoursLabel);
            this.Controls.Add(this.playlistHoursUpDown);
            this.Controls.Add(this.playlistDurationLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoriesDataGridView);
            this.Controls.Add(this.pathIncorrectLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.minSecondLabel);
            this.Controls.Add(this.minSecondUpDown);
            this.Controls.Add(this.minMinutesLabel);
            this.Controls.Add(this.minMinutesUpDown);
            this.Controls.Add(this.maxSecondLable);
            this.Controls.Add(this.maxSecondUpDown);
            this.Controls.Add(this.maxMinutesLable);
            this.Controls.Add(this.maxMinutesUpDown);
            this.Controls.Add(this.minDurationLabel);
            this.Controls.Add(this.maxDurationLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.folderPathLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(952, 531);
            this.Name = "MainForm";
            this.Text = "Lazy DJ";
            ((System.ComponentModel.ISupportInitialize)(this.maxMinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistMinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistHoursUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderPathLable;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label maxDurationLabel;
        private System.Windows.Forms.Label minDurationLabel;
        private System.Windows.Forms.NumericUpDown maxMinutesUpDown;
        private System.Windows.Forms.Label maxMinutesLable;
        private System.Windows.Forms.Label maxSecondLable;
        private System.Windows.Forms.NumericUpDown maxSecondUpDown;
        private System.Windows.Forms.Label minSecondLabel;
        private System.Windows.Forms.NumericUpDown minSecondUpDown;
        private System.Windows.Forms.Label minMinutesLabel;
        private System.Windows.Forms.NumericUpDown minMinutesUpDown;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label pathIncorrectLabel;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private Button upButton;
        private Button downButton;
        private Button deleteButton;
        private Label playlistMinLabel;
        private NumericUpDown playlistMinutesUpDown;
        private Label playlistHoursLabel;
        private NumericUpDown playlistHoursUpDown;
        private Label playlistDurationLabel;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn MaxDuration;
        private DataGridViewTextBoxColumn MinDuration;
        private DataGridViewTextBoxColumn SortBy;
        private DataGridViewTextBoxColumn Id;
    }
}

