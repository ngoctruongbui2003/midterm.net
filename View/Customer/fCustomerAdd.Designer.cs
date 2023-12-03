namespace Midterm_CarRental.View.Customer
{
    partial class fCustomerAdd
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
            tbName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            tbIdentityCard = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            tbPhone = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            rbWomen = new RadioButton();
            rbMan = new RadioButton();
            label3 = new Label();
            panel6 = new Panel();
            tbAddress = new TextBox();
            label5 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            btnExit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 64);
            panel1.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(510, 27);
            tbName.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(tbIdentityCard);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 64);
            panel2.TabIndex = 2;
            // 
            // tbIdentityCard
            // 
            tbIdentityCard.Location = new Point(105, 20);
            tbIdentityCard.Name = "tbIdentityCard";
            tbIdentityCard.Size = new Size(510, 27);
            tbIdentityCard.TabIndex = 2;
            tbIdentityCard.KeyPress += tbIdentityCard_KeyPress;
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
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 64);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbPhone);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(283, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(332, 58);
            panel5.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(109, 14);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(220, 27);
            tbPhone.TabIndex = 4;
            tbPhone.TextChanged += tbPhone_TextChanged;
            tbPhone.KeyPress += tbPhone_KeyPress;
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
            // panel4
            // 
            panel4.Controls.Add(rbWomen);
            panel4.Controls.Add(rbMan);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(274, 58);
            panel4.TabIndex = 2;
            // 
            // rbWomen
            // 
            rbWomen.AutoSize = true;
            rbWomen.Location = new Point(175, 18);
            rbWomen.Name = "rbWomen";
            rbWomen.Size = new Size(50, 24);
            rbWomen.TabIndex = 2;
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
            rbMan.TabIndex = 1;
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
            // panel6
            // 
            panel6.Controls.Add(tbAddress);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(636, 64);
            panel6.TabIndex = 2;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(105, 20);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(510, 27);
            tbAddress.TabIndex = 5;
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
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 284);
            panel8.Name = "panel8";
            panel8.Size = new Size(636, 83);
            panel8.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnExit);
            panel9.Controls.Add(btnAdd);
            panel9.Location = new Point(368, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(262, 77);
            panel9.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(155, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 66);
            btnExit.TabIndex = 8;
            btnExit.Text = "Hủy";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 66);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // fCustomerAdd
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 367);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCustomerAdd";
            Text = "Thêm khách hàng";
            Load += fCustomerAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbName;
        private Label label1;
        private Panel panel2;
        private TextBox tbIdentityCard;
        private Label label2;
        private Panel panel3;
        private Panel panel5;
        private TextBox tbPhone;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Panel panel6;
        private TextBox tbAddress;
        private Label label5;
        private Panel panel8;
        private Panel panel9;
        private Button btnExit;
        private Button btnAdd;
        private RadioButton rbWomen;
        private RadioButton rbMan;
    }
}