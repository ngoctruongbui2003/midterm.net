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
            tbName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lbUrl = new Label();
            pbCar = new PictureBox();
            btnUploadImage = new Button();
            label6 = new Label();
            panel7 = new Panel();
            tbDescription = new TextBox();
            panel3 = new Panel();
            cbFuel = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            cbCategory = new ComboBox();
            label7 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            cbBrand = new ComboBox();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(155, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 67);
            button2.TabIndex = 8;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 67);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 565);
            panel8.Name = "panel8";
            panel8.Size = new Size(496, 83);
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
            panel6.Size = new Size(496, 64);
            panel6.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(263, 27);
            tbName.TabIndex = 2;
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
            panel2.Controls.Add(tbName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 64);
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
            panel1.Size = new Size(496, 141);
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
            btnUploadImage.Size = new Size(104, 67);
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
            panel7.Controls.Add(tbDescription);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 269);
            panel7.Name = "panel7";
            panel7.Size = new Size(496, 133);
            panel7.TabIndex = 8;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(105, 20);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(263, 105);
            tbDescription.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbFuel);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 402);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 63);
            panel3.TabIndex = 11;
            // 
            // cbFuel
            // 
            cbFuel.FormattingEnabled = true;
            cbFuel.Location = new Point(106, 17);
            cbFuel.Margin = new Padding(3, 4, 3, 4);
            cbFuel.Name = "cbFuel";
            cbFuel.Size = new Size(263, 28);
            cbFuel.TabIndex = 1;
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
            // panel4
            // 
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 465);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(496, 96);
            panel4.TabIndex = 12;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(344, 21);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(138, 28);
            cbCategory.TabIndex = 2;
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
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(cbBrand);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 96);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "Hãng:";
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(106, 15);
            cbBrand.Margin = new Padding(3, 4, 3, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(138, 28);
            cbBrand.TabIndex = 1;
            // 
            // fCarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 648);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCarAdd";
            Text = "fCarAdd";
            Load += fCarAdd_Load;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private TextBox tbName;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Panel panel7;
        private TextBox tbDescription;
        private Label lbUrl;
        private PictureBox pbCar;
        private Button btnUploadImage;
        private Panel panel3;
        private ComboBox cbFuel;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private ComboBox cbBrand;
        private ComboBox cbCategory;
        private Label label7;
        private Panel panel5;
    }
}