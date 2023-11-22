namespace Midterm_CarRental.View.Rent
{
    partial class fRentManager
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
            panel5 = new Panel();
            dgvRent = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NameCar = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            DateRent = new DataGridViewTextBoxColumn();
            DateReturn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnRentInfo = new FontAwesome.Sharp.IconButton();
            btnChangeStatus = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            cbSearch = new ComboBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            tbSearch = new TextBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRent).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(dgvRent);
            panel5.Location = new Point(0, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(1330, 739);
            panel5.TabIndex = 3;
            // 
            // dgvRent
            // 
            dgvRent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRent.Columns.AddRange(new DataGridViewColumn[] { Id, NameCar, LicensePlate, NameCustomer, IdentityCard, Phone, DateRent, DateReturn, Status });
            dgvRent.Location = new Point(3, 3);
            dgvRent.MultiSelect = false;
            dgvRent.Name = "dgvRent";
            dgvRent.ReadOnly = true;
            dgvRent.RowHeadersWidth = 51;
            dgvRent.RowTemplate.Height = 29;
            dgvRent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRent.Size = new Size(1324, 733);
            dgvRent.TabIndex = 0;
            dgvRent.CellClick += dgvRent_CellClick;
            dgvRent.CellFormatting += dgvRent_CellFormatting;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
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
            LicensePlate.HeaderText = "Biển số xe";
            LicensePlate.MinimumWidth = 6;
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            LicensePlate.Width = 125;
            // 
            // NameCustomer
            // 
            NameCustomer.HeaderText = "Họ và tên khách hàng";
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
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 125;
            // 
            // DateRent
            // 
            DateRent.HeaderText = "Ngày thuê";
            DateRent.MinimumWidth = 6;
            DateRent.Name = "DateRent";
            DateRent.ReadOnly = true;
            DateRent.Width = 125;
            // 
            // DateReturn
            // 
            DateReturn.HeaderText = "Ngày trả";
            DateReturn.MinimumWidth = 6;
            DateReturn.Name = "DateReturn";
            DateReturn.ReadOnly = true;
            DateReturn.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRentInfo);
            panel4.Controls.Add(btnChangeStatus);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(cbSearch);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(tbSearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1333, 77);
            panel4.TabIndex = 2;
            // 
            // btnRentInfo
            // 
            btnRentInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRentInfo.IconColor = Color.Black;
            btnRentInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRentInfo.IconSize = 20;
            btnRentInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentInfo.Location = new Point(757, 4);
            btnRentInfo.Margin = new Padding(3, 4, 3, 4);
            btnRentInfo.Name = "btnRentInfo";
            btnRentInfo.Size = new Size(104, 71);
            btnRentInfo.TabIndex = 19;
            btnRentInfo.Text = "Xem thông tin hóa đơn";
            btnRentInfo.UseVisualStyleBackColor = true;
            btnRentInfo.Click += btnRentInfo_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            btnChangeStatus.IconColor = Color.Black;
            btnChangeStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeStatus.IconSize = 20;
            btnChangeStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeStatus.Location = new Point(1205, 4);
            btnChangeStatus.Margin = new Padding(3, 4, 3, 4);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(122, 71);
            btnChangeStatus.TabIndex = 18;
            btnChangeStatus.Text = "Xác nhận trả xe";
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // btnDelete
            // 
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(867, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 71);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(381, 24);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(155, 28);
            cbSearch.TabIndex = 16;
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
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(6, 25);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm";
            tbSearch.Size = new Size(365, 27);
            tbSearch.TabIndex = 1;
            // 
            // fRentManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 818);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Name = "fRentManager";
            Text = "RentManager";
            WindowState = FormWindowState.Maximized;
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRent).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private DataGridView dgvRent;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameCar;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn IdentityCard;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn DateRent;
        private DataGridViewTextBoxColumn DateReturn;
        private DataGridViewTextBoxColumn Status;
        private Panel panel4;
        private ComboBox cbSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox tbSearch;
        private FontAwesome.Sharp.IconButton btnChangeStatus;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnRentInfo;
    }
}