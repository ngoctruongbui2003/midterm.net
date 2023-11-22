namespace Midterm_CarRental.View
{
    partial class fCustomer
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
            panel7 = new Panel();
            tbAddress = new TextBox();
            label5 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            tbPhone = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            rbWomen = new RadioButton();
            rbMan = new RadioButton();
            label3 = new Label();
            panel11 = new Panel();
            tbIdentityCard = new TextBox();
            label2 = new Label();
            panel12 = new Panel();
            tbName = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            tbId = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel5 = new Panel();
            dgvCustomer = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            cbSearch = new ComboBox();
            btnExportExcel = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            tbSearch = new TextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 822);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(tbAddress);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 257);
            panel7.Name = "panel7";
            panel7.Size = new Size(669, 64);
            panel7.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(105, 20);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(510, 27);
            tbAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 23);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ:";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 193);
            panel8.Name = "panel8";
            panel8.Size = new Size(669, 64);
            panel8.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Controls.Add(tbPhone);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(237, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(378, 58);
            panel9.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(109, 14);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(220, 27);
            tbPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "Số điện thoại:";
            // 
            // panel10
            // 
            panel10.Controls.Add(rbWomen);
            panel10.Controls.Add(rbMan);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(228, 58);
            panel10.TabIndex = 2;
            // 
            // rbWomen
            // 
            rbWomen.AutoSize = true;
            rbWomen.Location = new Point(175, 18);
            rbWomen.Name = "rbWomen";
            rbWomen.Size = new Size(50, 24);
            rbWomen.TabIndex = 6;
            rbWomen.TabStop = true;
            rbWomen.Text = "Nữ";
            rbWomen.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Location = new Point(107, 18);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(62, 24);
            rbMan.TabIndex = 5;
            rbMan.TabStop = true;
            rbMan.Text = "Nam";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 17);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 0;
            label3.Text = "Giới tính:";
            // 
            // panel11
            // 
            panel11.Controls.Add(tbIdentityCard);
            panel11.Controls.Add(label2);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 129);
            panel11.Name = "panel11";
            panel11.Size = new Size(669, 64);
            panel11.TabIndex = 6;
            // 
            // tbIdentityCard
            // 
            tbIdentityCard.Location = new Point(105, 20);
            tbIdentityCard.Name = "tbIdentityCard";
            tbIdentityCard.Size = new Size(510, 27);
            tbIdentityCard.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 23);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "CCCD:";
            // 
            // panel12
            // 
            panel12.Controls.Add(tbName);
            panel12.Controls.Add(label1);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 65);
            panel12.Name = "panel12";
            panel12.Size = new Size(669, 64);
            panel12.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(510, 27);
            tbName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // panel6
            // 
            panel6.Controls.Add(tbId);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(669, 65);
            panel6.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.Location = new Point(105, 22);
            tbId.Name = "tbId";
            tbId.Size = new Size(510, 27);
            tbId.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 25);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 712);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 110);
            panel3.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 20;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(513, 16);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 81);
            btnCancel.TabIndex = 13;
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
            btnSave.Location = new Point(391, 16);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 81);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(154, 16);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 81);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(32, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 81);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(272, 16);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 81);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(669, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 822);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvCustomer);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(768, 745);
            panel5.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Id, NameCustomer, IdentityCard, Gender, Phone, Address });
            dgvCustomer.Location = new Point(6, 6);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(759, 736);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // NameCustomer
            // 
            NameCustomer.HeaderText = "Họ và tên";
            NameCustomer.MinimumWidth = 6;
            NameCustomer.Name = "NameCustomer";
            NameCustomer.ReadOnly = true;
            NameCustomer.Width = 125;
            // 
            // IdentityCard
            // 
            IdentityCard.HeaderText = "CCCD";
            IdentityCard.MinimumWidth = 6;
            IdentityCard.Name = "IdentityCard";
            IdentityCard.ReadOnly = true;
            IdentityCard.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbSearch);
            panel4.Controls.Add(btnExportExcel);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(tbSearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(768, 77);
            panel4.TabIndex = 0;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(381, 24);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(155, 28);
            cbSearch.TabIndex = 16;
            // 
            // btnExportExcel
            // 
            btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportExcel.IconColor = Color.Black;
            btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportExcel.IconSize = 20;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(652, 3);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(104, 71);
            btnExportExcel.TabIndex = 15;
            btnExportExcel.Text = "Xuất file Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(542, 4);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 71);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(6, 25);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm";
            tbSearch.Size = new Size(365, 27);
            tbSearch.TabIndex = 1;
            // 
            // fCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 822);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCustomer";
            Text = "fCustomer";
            WindowState = FormWindowState.Maximized;
            Load += fCustomer_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private Panel panel5;
        private DataGridView dgvCustomer;
        private Panel panel4;
        private TextBox tbSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel7;
        private TextBox tbAddress;
        private Label label5;
        private Panel panel8;
        private Panel panel9;
        private TextBox tbPhone;
        private Label label4;
        private Panel panel10;
        private RadioButton rbWomen;
        private RadioButton rbMan;
        private Label label3;
        private Panel panel11;
        private TextBox tbIdentityCard;
        private Label label2;
        private Panel panel12;
        private TextBox tbName;
        private Label label1;
        private Panel panel6;
        private TextBox tbId;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn IdentityCard;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private ComboBox cbSearch;
    }
}