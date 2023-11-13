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
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 98);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời gian thuê";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(91, 55);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(244, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Ngày trả:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Ngày thuê:";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(13, 546);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(471, 126);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tính năng";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 429);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khách hàng";
            // 
            // fRentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 751);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "fRentAdd";
            Text = "fRentAdd";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
    }
}