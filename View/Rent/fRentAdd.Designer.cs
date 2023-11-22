namespace Midterm_CarRental.View.Rent
{
    partial class fRentAdd
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
            groupBox1 = new GroupBox();
            dtpDateReturn = new DateTimePicker();
            label2 = new Label();
            groupBox3 = new GroupBox();
            flpFeature = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
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
            panel1 = new Panel();
            btnSearchCar = new Button();
            tbSearchCar = new TextBox();
            groupBox4 = new GroupBox();
            panel3 = new Panel();
            dgvCustomer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NameCustomer = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnSearchCustomer = new Button();
            tbSearchCustomer = new TextBox();
            panel5 = new Panel();
            btnRefesh = new Button();
            btnInfoPrice = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDateReturn);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 9);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(922, 99);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời gian thuê";
            // 
            // dtpDateReturn
            // 
            dtpDateReturn.Location = new Point(82, 50);
            dtpDateReturn.Margin = new Padding(3, 4, 3, 4);
            dtpDateReturn.Name = "dtpDateReturn";
            dtpDateReturn.Size = new Size(278, 27);
            dtpDateReturn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày trả:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(flpFeature);
            groupBox3.Location = new Point(15, 728);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(922, 168);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tính năng";
            // 
            // flpFeature
            // 
            flpFeature.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flpFeature.Location = new Point(7, 27);
            flpFeature.Name = "flpFeature";
            flpFeature.Size = new Size(909, 134);
            flpFeature.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(14, 148);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(923, 572);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xe";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(dgvCar);
            panel2.Location = new Point(8, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 464);
            panel2.TabIndex = 1;
            // 
            // dgvCar
            // 
            dgvCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCar.Columns.AddRange(new DataGridViewColumn[] { ID, NameCar, LicensePlate, Price, Description, Fuel, Brand, Category, DateAdded, Status });
            dgvCar.Location = new Point(3, 3);
            dgvCar.MultiSelect = false;
            dgvCar.Name = "dgvCar";
            dgvCar.ReadOnly = true;
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCar.Size = new Size(903, 458);
            dgvCar.TabIndex = 2;
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
            // panel1
            // 
            panel1.Controls.Add(btnSearchCar);
            panel1.Controls.Add(tbSearchCar);
            panel1.Location = new Point(8, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 68);
            panel1.TabIndex = 0;
            // 
            // btnSearchCar
            // 
            btnSearchCar.Location = new Point(280, 3);
            btnSearchCar.Name = "btnSearchCar";
            btnSearchCar.Size = new Size(95, 62);
            btnSearchCar.TabIndex = 1;
            btnSearchCar.Text = "Tìm kiếm";
            btnSearchCar.UseVisualStyleBackColor = true;
            btnSearchCar.Click += btnSearchCar_Click;
            // 
            // tbSearchCar
            // 
            tbSearchCar.Location = new Point(3, 17);
            tbSearchCar.Name = "tbSearchCar";
            tbSearchCar.PlaceholderText = "Tìm kiếm tên xe";
            tbSearchCar.Size = new Size(228, 27);
            tbSearchCar.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(panel3);
            groupBox4.Controls.Add(panel4);
            groupBox4.Location = new Point(943, 13);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(405, 700);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Khách hàng thuê";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvCustomer);
            panel3.Location = new Point(8, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 592);
            panel3.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, NameCustomer, IdentityCard, Gender, Phone, Address });
            dgvCustomer.Location = new Point(3, 3);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(385, 589);
            dgvCustomer.TabIndex = 1;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
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
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnSearchCustomer);
            panel4.Controls.Add(tbSearchCustomer);
            panel4.Location = new Point(8, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 68);
            panel4.TabIndex = 0;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(342, 3);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(95, 62);
            btnSearchCustomer.TabIndex = 1;
            btnSearchCustomer.Text = "Tìm kiếm";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // tbSearchCustomer
            // 
            tbSearchCustomer.Location = new Point(3, 17);
            tbSearchCustomer.Name = "tbSearchCustomer";
            tbSearchCustomer.PlaceholderText = "Tìm kiếm khách hàng";
            tbSearchCustomer.Size = new Size(294, 27);
            tbSearchCustomer.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.Controls.Add(btnRefesh);
            panel5.Controls.Add(btnInfoPrice);
            panel5.Location = new Point(943, 737);
            panel5.Name = "panel5";
            panel5.Size = new Size(405, 159);
            panel5.TabIndex = 6;
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefesh.Location = new Point(11, 39);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(108, 95);
            btnRefesh.TabIndex = 2;
            btnRefesh.Text = "Làm mới";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnInfoPrice
            // 
            btnInfoPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInfoPrice.Location = new Point(288, 39);
            btnInfoPrice.Name = "btnInfoPrice";
            btnInfoPrice.Size = new Size(108, 95);
            btnInfoPrice.TabIndex = 0;
            btnInfoPrice.Text = "Xem thông tin giá";
            btnInfoPrice.UseVisualStyleBackColor = true;
            btnInfoPrice.Click += btnInfoPrice_Click;
            // 
            // fRentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 905);
            Controls.Add(panel5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fRentAdd";
            Text = "fRentAdd";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDateReturn;
        private Label label2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpFeature;
        private Panel panel2;
        private Panel panel1;
        private Button btnSearchCar;
        private TextBox tbSearchCar;
        private GroupBox groupBox4;
        private Panel panel3;
        private Panel panel4;
        private Button btnSearchCustomer;
        private TextBox tbSearchCustomer;
        private Panel panel5;
        private Button btnRefesh;
        private Button btnInfoPrice;
        private DataGridView dgvCar;
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
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NameCustomer;
        private DataGridViewTextBoxColumn IdentityCard;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
    }
}