namespace Midterm_CarRental.View.Car
{
    partial class fCarAdd
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
            button2 = new Button();
            btnAdd = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            tbLicensePlate = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lbUrl = new Label();
            pbCar = new PictureBox();
            btnUploadImage = new Button();
            label6 = new Label();
            panel7 = new Panel();
            textBox3 = new TextBox();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(155, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 66);
            button2.TabIndex = 8;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
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
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 499);
            panel8.Name = "panel8";
            panel8.Size = new Size(378, 83);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Controls.Add(button2);
            panel9.Controls.Add(btnAdd);
            panel9.Location = new Point(106, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(262, 77);
            panel9.TabIndex = 0;
            // 
            // tbLicensePlate
            // 
            tbLicensePlate.Location = new Point(105, 20);
            tbLicensePlate.Name = "tbLicensePlate";
            tbLicensePlate.Size = new Size(263, 27);
            tbLicensePlate.TabIndex = 5;
            tbLicensePlate.TextChanged += tbLicensePlate_TextChanged;
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
            // panel6
            // 
            panel6.Controls.Add(tbLicensePlate);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 205);
            panel6.Name = "panel6";
            panel6.Size = new Size(378, 64);
            panel6.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 27);
            textBox2.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 64);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Hình xe:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbUrl);
            panel1.Controls.Add(pbCar);
            panel1.Controls.Add(btnUploadImage);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 141);
            panel1.TabIndex = 5;
            // 
            // lbUrl
            // 
            lbUrl.AutoSize = true;
            lbUrl.Location = new Point(105, 23);
            lbUrl.Name = "lbUrl";
            lbUrl.Size = new Size(84, 20);
            lbUrl.TabIndex = 11;
            lbUrl.Text = "Đường dẫn";
            // 
            // pbCar
            // 
            pbCar.Location = new Point(248, 7);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(120, 120);
            pbCar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCar.TabIndex = 10;
            pbCar.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(105, 55);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(104, 66);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Tải ảnh";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
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
            // panel7
            // 
            panel7.Controls.Add(textBox3);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 269);
            panel7.Name = "panel7";
            panel7.Size = new Size(378, 133);
            panel7.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 20);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 106);
            textBox3.TabIndex = 1;
            // 
            // fCarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 582);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCarAdd";
            Text = "fCarAdd";
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btnAdd;
        private Panel panel8;
        private Panel panel9;
        private TextBox tbLicensePlate;
        private Label label5;
        private Panel panel6;
        private TextBox textBox2;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Panel panel7;
        private TextBox textBox3;
        private Label lbUrl;
        private PictureBox pbCar;
        private Button btnUploadImage;
    }
}