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
            cbSearchBy = new ComboBox();
            btnAddExcel = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            cbSearch = new ComboBox();
            tbSearch = new TextBox();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            cbCategory = new ComboBox();
            label7 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            cbBrand = new ComboBox();
            panel9 = new Panel();
            cbFuel = new ComboBox();
            label3 = new Label();
            panel12 = new Panel();
            tbDescription = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            tbPrice = new TextBox();
            label8 = new Label();
            panel10 = new Panel();
            tbLicensePlate = new TextBox();
            label5 = new Label();
            panel11 = new Panel();
            tbName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            tbId = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dgvCar = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameCar = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Fuel = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            DateAdded = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbSearchBy);
            panel1.Controls.Add(btnAddExcel);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Location = new Point(635, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 77);
            panel1.TabIndex = 0;
            // 
            // cbSearchBy
            // 
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Location = new Point(229, 45);
            cbSearchBy.Margin = new Padding(3, 4, 3, 4);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(210, 28);
            cbSearchBy.TabIndex = 5;
            // 
            // btnAddExcel
            // 
            btnAddExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddExcel.IconColor = Color.Black;
            btnAddExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddExcel.IconSize = 20;
            btnAddExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddExcel.Location = new Point(704, 2);
            btnAddExcel.Margin = new Padding(3, 4, 3, 4);
            btnAddExcel.Name = "btnAddExcel";
            btnAddExcel.Size = new Size(104, 71);
            btnAddExcel.TabIndex = 4;
            btnAddExcel.Text = "Thêm bằng Excel";
            btnAddExcel.UseVisualStyleBackColor = true;
            btnAddExcel.Click += btnAddExcel_Click;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(453, 2);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 71);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(229, 9);
            cbSearch.Margin = new Padding(3, 4, 3, 4);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(210, 28);
            cbSearch.TabIndex = 2;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            cbSearch.SelectedValueChanged += cbSearch_SelectedValueChanged;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(17, 20);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm ";
            tbSearch.Size = new Size(195, 27);
            tbSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(13, 9);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 81);
            btnAdd.TabIndex = 11;
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
            panel2.Size = new Size(1464, 777);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 771);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(cbCategory);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 444);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(626, 96);
            panel7.TabIndex = 20;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(344, 21);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(138, 28);
            cbCategory.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 25);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 2;
            label7.Text = "Loại xe:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Controls.Add(cbBrand);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(258, 96);
            panel8.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 24);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "Hãng:";
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(105, 21);
            cbBrand.Margin = new Padding(3, 4, 3, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(138, 28);
            cbBrand.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFuel);
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 381);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(626, 63);
            panel9.TabIndex = 19;
            // 
            // cbFuel
            // 
            cbFuel.FormattingEnabled = true;
            cbFuel.Location = new Point(106, 17);
            cbFuel.Margin = new Padding(3, 4, 3, 4);
            cbFuel.Name = "cbFuel";
            cbFuel.Size = new Size(263, 28);
            cbFuel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Nhiên liệu:";
            // 
            // panel12
            // 
            panel12.Controls.Add(tbDescription);
            panel12.Controls.Add(label6);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 248);
            panel12.Name = "panel12";
            panel12.Size = new Size(626, 133);
            panel12.TabIndex = 18;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(105, 20);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(263, 105);
            tbDescription.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 23);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 0;
            label6.Text = "Mô tả:";
            // 
            // panel6
            // 
            panel6.Controls.Add(tbPrice);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 188);
            panel6.Name = "panel6";
            panel6.Size = new Size(626, 60);
            panel6.TabIndex = 15;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(105, 16);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(263, 27);
            tbPrice.TabIndex = 8;
            tbPrice.TextChanged += tbPrice_TextChanged;
            tbPrice.KeyPress += tbPrice_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 19);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 7;
            label8.Text = "Giá tiền:";
            // 
            // panel10
            // 
            panel10.Controls.Add(tbLicensePlate);
            panel10.Controls.Add(label5);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 124);
            panel10.Name = "panel10";
            panel10.Size = new Size(626, 64);
            panel10.TabIndex = 13;
            // 
            // tbLicensePlate
            // 
            tbLicensePlate.Location = new Point(105, 20);
            tbLicensePlate.Name = "tbLicensePlate";
            tbLicensePlate.Size = new Size(263, 27);
            tbLicensePlate.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 23);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Biển số xe:";
            // 
            // panel11
            // 
            panel11.Controls.Add(tbName);
            panel11.Controls.Add(label2);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 60);
            panel11.Name = "panel11";
            panel11.Size = new Size(626, 64);
            panel11.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(263, 27);
            tbName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên xe:";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbId);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 60);
            panel3.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.Location = new Point(106, 24);
            tbId.Name = "tbId";
            tbId.Size = new Size(263, 27);
            tbId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnDelete);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 675);
            panel5.Name = "panel5";
            panel5.Size = new Size(626, 96);
            panel5.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 20;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(494, 9);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 81);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 20;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(372, 9);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 81);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(253, 9);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 81);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(135, 9);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 81);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCar
            // 
            dgvCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCar.Columns.AddRange(new DataGridViewColumn[] { ID, NameCar, LicensePlate, Price, Description, Fuel, Brand, Category, DateAdded, Status });
            dgvCar.Location = new Point(635, 84);
            dgvCar.MultiSelect = false;
            dgvCar.Name = "dgvCar";
            dgvCar.ReadOnly = true;
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCar.Size = new Size(826, 690);
            dgvCar.TabIndex = 1;
            dgvCar.CellClick += dgvCar_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // NameCar
            // 
            NameCar.HeaderText = "Tên xe";
            NameCar.MinimumWidth = 6;
            NameCar.Name = "NameCar";
            NameCar.ReadOnly = true;
            NameCar.Width = 125;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "Biển số";
            LicensePlate.MinimumWidth = 6;
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            LicensePlate.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Giá tiền";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 125;
            // 
            // Fuel
            // 
            Fuel.HeaderText = "Nhiên liệu";
            Fuel.MinimumWidth = 6;
            Fuel.Name = "Fuel";
            Fuel.ReadOnly = true;
            Fuel.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Hãng";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Loại xe";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // DateAdded
            // 
            DateAdded.HeaderText = "Ngày thêm";
            DateAdded.MinimumWidth = 6;
            DateAdded.Name = "DateAdded";
            DateAdded.ReadOnly = true;
            DateAdded.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // fCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 777);
            Controls.Add(panel2);
            Name = "fCar";
            Text = "CarForm";
            WindowState = FormWindowState.Maximized;
            Load += fCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ComboBox cbSearch;
        private TextBox tbSearch;
        private Panel panel2;
        private DataGridView dgvCar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btnSave;
        private Panel panel10;
        private TextBox tbLicensePlate;
        private Label label5;
        private Panel panel11;
        private TextBox tbName;
        private Label label2;
        private Panel panel3;
        private TextBox tbId;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAddExcel;
        private FontAwesome.Sharp.IconButton btnCancel;
        private ComboBox cbSearchBy;
        private Panel panel7;
        private ComboBox cbCategory;
        private Label label7;
        private Panel panel8;
        private Label label4;
        private ComboBox cbBrand;
        private Panel panel9;
        private ComboBox cbFuel;
        private Label label3;
        private Panel panel12;
        private TextBox tbDescription;
        private Label label6;
        private Panel panel6;
        private TextBox tbPrice;
        private Label label8;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameCar;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Fuel;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn Status;
    }
}