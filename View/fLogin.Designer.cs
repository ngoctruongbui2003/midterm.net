namespace Midterm_CarRental
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tbUsername = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            tbPassword = new TextBox();
            panel3 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbUsername);
            panel1.Location = new Point(58, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 53);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(142, 10);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(416, 27);
            tbUsername.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbPassword);
            panel2.Location = new Point(58, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 53);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(142, 10);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(416, 27);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(341, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 75);
            panel3.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(165, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 66);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(6, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 66);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(128, 25);
            label3.Name = "label3";
            label3.Size = new Size(400, 81);
            label3.TabIndex = 8;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 560);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tbUsername;
        private Panel panel2;
        private Label label2;
        private TextBox tbPassword;
        private Panel panel3;
        private Button btnExit;
        private Button btnLogin;
        private Label label3;
    }
}