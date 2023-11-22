namespace Midterm_CarRental.View
{
    partial class fMain
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
            pnMenu = new Panel();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            btnStatisticalForm = new FontAwesome.Sharp.IconButton();
            btnBillForm = new FontAwesome.Sharp.IconButton();
            btnRentForm = new FontAwesome.Sharp.IconButton();
            btnCustomerForm = new FontAwesome.Sharp.IconButton();
            btnCarForm = new FontAwesome.Sharp.IconButton();
            pnLogo = new Panel();
            panel1 = new Panel();
            iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            lbHello = new Label();
            lbChildForm = new Label();
            pnDesktopPane = new Panel();
            pnMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconChildForm).BeginInit();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(51, 51, 76);
            pnMenu.Controls.Add(btnLogOut);
            pnMenu.Controls.Add(btnStatisticalForm);
            pnMenu.Controls.Add(btnBillForm);
            pnMenu.Controls.Add(btnRentForm);
            pnMenu.Controls.Add(btnCustomerForm);
            pnMenu.Controls.Add(btnCarForm);
            pnMenu.Controls.Add(pnLogo);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(191, 675);
            pnMenu.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = SystemColors.Control;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            btnLogOut.IconColor = Color.White;
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.IconSize = 32;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 620);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(10, 0, 20, 0);
            btnLogOut.Size = new Size(191, 55);
            btnLogOut.TabIndex = 13;
            btnLogOut.Text = "ĐĂNG XUẤT";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnStatisticalForm
            // 
            btnStatisticalForm.Dock = DockStyle.Top;
            btnStatisticalForm.FlatAppearance.BorderSize = 0;
            btnStatisticalForm.FlatStyle = FlatStyle.Flat;
            btnStatisticalForm.ForeColor = SystemColors.Control;
            btnStatisticalForm.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnStatisticalForm.IconColor = Color.White;
            btnStatisticalForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStatisticalForm.IconSize = 32;
            btnStatisticalForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatisticalForm.Location = new Point(0, 304);
            btnStatisticalForm.Name = "btnStatisticalForm";
            btnStatisticalForm.Padding = new Padding(10, 0, 20, 0);
            btnStatisticalForm.Size = new Size(191, 55);
            btnStatisticalForm.TabIndex = 12;
            btnStatisticalForm.Text = "THỐNG KÊ";
            btnStatisticalForm.TextAlign = ContentAlignment.MiddleLeft;
            btnStatisticalForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatisticalForm.UseVisualStyleBackColor = true;
            btnStatisticalForm.Click += btnStatisticalForm_Click;
            // 
            // btnBillForm
            // 
            btnBillForm.Dock = DockStyle.Top;
            btnBillForm.FlatAppearance.BorderSize = 0;
            btnBillForm.FlatStyle = FlatStyle.Flat;
            btnBillForm.ForeColor = SystemColors.Control;
            btnBillForm.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnBillForm.IconColor = Color.White;
            btnBillForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBillForm.IconSize = 32;
            btnBillForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnBillForm.Location = new Point(0, 249);
            btnBillForm.Name = "btnBillForm";
            btnBillForm.Padding = new Padding(10, 0, 20, 0);
            btnBillForm.Size = new Size(191, 55);
            btnBillForm.TabIndex = 11;
            btnBillForm.Text = "HÓA ĐƠN";
            btnBillForm.TextAlign = ContentAlignment.MiddleLeft;
            btnBillForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBillForm.UseVisualStyleBackColor = true;
            btnBillForm.Click += btnBillForm_Click;
            // 
            // btnRentForm
            // 
            btnRentForm.Dock = DockStyle.Top;
            btnRentForm.FlatAppearance.BorderSize = 0;
            btnRentForm.FlatStyle = FlatStyle.Flat;
            btnRentForm.ForeColor = SystemColors.Control;
            btnRentForm.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            btnRentForm.IconColor = Color.White;
            btnRentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRentForm.IconSize = 32;
            btnRentForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentForm.Location = new Point(0, 194);
            btnRentForm.Name = "btnRentForm";
            btnRentForm.Padding = new Padding(10, 0, 20, 0);
            btnRentForm.Size = new Size(191, 55);
            btnRentForm.TabIndex = 10;
            btnRentForm.Text = "THUÊ XE";
            btnRentForm.TextAlign = ContentAlignment.MiddleLeft;
            btnRentForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentForm.UseVisualStyleBackColor = true;
            btnRentForm.Click += btnRentForm_Click;
            // 
            // btnCustomerForm
            // 
            btnCustomerForm.Dock = DockStyle.Top;
            btnCustomerForm.FlatAppearance.BorderSize = 0;
            btnCustomerForm.FlatStyle = FlatStyle.Flat;
            btnCustomerForm.ForeColor = SystemColors.Control;
            btnCustomerForm.IconChar = FontAwesome.Sharp.IconChar.Person;
            btnCustomerForm.IconColor = Color.White;
            btnCustomerForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomerForm.IconSize = 32;
            btnCustomerForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerForm.Location = new Point(0, 139);
            btnCustomerForm.Name = "btnCustomerForm";
            btnCustomerForm.Padding = new Padding(10, 0, 20, 0);
            btnCustomerForm.Size = new Size(191, 55);
            btnCustomerForm.TabIndex = 9;
            btnCustomerForm.Text = "KHÁCH HÀNG";
            btnCustomerForm.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerForm.UseVisualStyleBackColor = true;
            btnCustomerForm.Click += btnCustomerForm_Click;
            // 
            // btnCarForm
            // 
            btnCarForm.Dock = DockStyle.Top;
            btnCarForm.FlatAppearance.BorderSize = 0;
            btnCarForm.FlatStyle = FlatStyle.Flat;
            btnCarForm.ForeColor = SystemColors.Control;
            btnCarForm.IconChar = FontAwesome.Sharp.IconChar.Car;
            btnCarForm.IconColor = Color.White;
            btnCarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCarForm.IconSize = 32;
            btnCarForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarForm.Location = new Point(0, 84);
            btnCarForm.Name = "btnCarForm";
            btnCarForm.Padding = new Padding(10, 0, 20, 0);
            btnCarForm.Size = new Size(191, 55);
            btnCarForm.TabIndex = 8;
            btnCarForm.Text = "XE Ô TÔ";
            btnCarForm.TextAlign = ContentAlignment.MiddleLeft;
            btnCarForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCarForm.UseVisualStyleBackColor = true;
            btnCarForm.Click += btnCarForm_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(39, 39, 58);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(191, 84);
            pnLogo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(iconChildForm);
            panel1.Controls.Add(lbHello);
            panel1.Controls.Add(lbChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(191, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 84);
            panel1.TabIndex = 4;
            // 
            // iconChildForm
            // 
            iconChildForm.BackColor = Color.FromArgb(39, 39, 58);
            iconChildForm.ForeColor = Color.Fuchsia;
            iconChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconChildForm.IconColor = Color.Fuchsia;
            iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconChildForm.IconSize = 40;
            iconChildForm.Location = new Point(39, 22);
            iconChildForm.Name = "iconChildForm";
            iconChildForm.Size = new Size(40, 40);
            iconChildForm.TabIndex = 2;
            iconChildForm.TabStop = false;
            // 
            // lbHello
            // 
            lbHello.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbHello.AutoSize = true;
            lbHello.ForeColor = Color.Fuchsia;
            lbHello.Location = new Point(831, 32);
            lbHello.Name = "lbHello";
            lbHello.Size = new Size(120, 20);
            lbHello.TabIndex = 1;
            lbHello.Text = "Xin chào, Trường";
            // 
            // lbChildForm
            // 
            lbChildForm.AutoSize = true;
            lbChildForm.ForeColor = Color.Fuchsia;
            lbChildForm.Location = new Point(85, 32);
            lbChildForm.Name = "lbChildForm";
            lbChildForm.Size = new Size(91, 20);
            lbChildForm.TabIndex = 0;
            lbChildForm.Text = "TRANG CHỦ";
            // 
            // pnDesktopPane
            // 
            pnDesktopPane.Dock = DockStyle.Fill;
            pnDesktopPane.Location = new Point(191, 84);
            pnDesktopPane.Name = "pnDesktopPane";
            pnDesktopPane.Size = new Size(967, 591);
            pnDesktopPane.TabIndex = 5;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 675);
            Controls.Add(pnDesktopPane);
            Controls.Add(panel1);
            Controls.Add(pnMenu);
            Name = "fMain";
            Text = "fMainForm";
            WindowState = FormWindowState.Maximized;
            FormClosing += fMain_FormClosing;
            pnMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnLogo;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnStatisticalForm;
        private FontAwesome.Sharp.IconButton btnBillForm;
        private FontAwesome.Sharp.IconButton btnRentForm;
        private FontAwesome.Sharp.IconButton btnCustomerForm;
        private FontAwesome.Sharp.IconButton btnCarForm;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private Label lbHello;
        private Label lbChildForm;
        private Panel pnDesktopPane;
    }
}