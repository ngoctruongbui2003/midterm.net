namespace Midterm_CarRental.View
{
    partial class fCar
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
            panel1 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            tbSearch = new TextBox();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel4 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dgvCar = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameCar = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Fuel = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            DateAdded = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(tbSearch);
            panel1.Location = new Point(533, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 77);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(438, 2);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 71);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(215, 16);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 2;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(14, 16);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(195, 27);
            tbSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(9, 9);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 81);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dgvCar);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1249, 611);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 605);
            panel4.TabIndex = 3;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(339, 14);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(0, 71);
            iconButton4.TabIndex = 6;
            iconButton4.Text = "Thêm";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(244, 9);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(104, 81);
            iconButton3.TabIndex = 5;
            iconButton3.Text = "Sửa";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(125, 9);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 81);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCar
            // 
            dgvCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCar.Columns.AddRange(new DataGridViewColumn[] { ID, NameCar, Image, LicensePlate, Description, Fuel, Brand, Category, DateAdded, Status });
            dgvCar.Location = new Point(533, 84);
            dgvCar.MultiSelect = false;
            dgvCar.Name = "dgvCar";
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCar.Size = new Size(713, 524);
            dgvCar.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NameCar
            // 
            NameCar.HeaderText = "Tên xe";
            NameCar.MinimumWidth = 6;
            NameCar.Name = "NameCar";
            NameCar.Width = 125;
            // 
            // Image
            // 
            Image.HeaderText = "Ảnh xe";
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            Image.Width = 125;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "Biển số";
            LicensePlate.MinimumWidth = 6;
            LicensePlate.Name = "LicensePlate";
            LicensePlate.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Fuel
            // 
            Fuel.HeaderText = "Nhiên liệu";
            Fuel.MinimumWidth = 6;
            Fuel.Name = "Fuel";
            Fuel.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Hãng";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Loại xe";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // DateAdded
            // 
            DateAdded.HeaderText = "Ngày thêm";
            DateAdded.MinimumWidth = 6;
            DateAdded.Name = "DateAdded";
            DateAdded.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // panel5
            // 
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(iconButton4);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(iconButton3);
            panel5.Controls.Add(btnDelete);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 509);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 96);
            panel5.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(364, 9);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(104, 81);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Sửa";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // fCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 611);
            Controls.Add(panel2);
            Name = "fCar";
            Text = "CarForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ComboBox comboBox1;
        private TextBox tbSearch;
        private Panel panel2;
        private DataGridView dgvCar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameCar;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Fuel;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn Status;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}