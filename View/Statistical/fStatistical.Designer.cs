namespace Midterm_CarRental.View.Statistical
{
    partial class fStatistical
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
            dgvReport = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            label4 = new Label();
            pieChart = new LiveCharts.WinForms.PieChart();
            panel1 = new Panel();
            lbSumRevenue = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnStatistical = new Button();
            dtpEnd = new DateTimePicker();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(dgvReport);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 799);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Báo cáo";
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { STT, Brand, Quantity, Revenue });
            dgvReport.Location = new Point(3, 23);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 29;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(570, 770);
            dgvReport.TabIndex = 0;
            // 
            // STT
            // 
            STT.HeaderText = "Số thứ tự";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Hãng xe";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Revenue
            // 
            Revenue.HeaderText = "Doanh thu";
            Revenue.MinimumWidth = 6;
            Revenue.Name = "Revenue";
            Revenue.ReadOnly = true;
            Revenue.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(597, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(861, 799);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Biểu đồ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pieChart);
            panel3.Location = new Point(12, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 621);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 15);
            label4.Name = "label4";
            label4.Size = new Size(746, 46);
            label4.TabIndex = 1;
            label4.Text = "BIỂU ĐỒ THỂ HIỆN SỰ PHÂN BỐ THEO HÃNG XE";
            // 
            // pieChart
            // 
            pieChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChart.Location = new Point(33, 75);
            pieChart.Name = "pieChart";
            pieChart.Size = new Size(795, 520);
            pieChart.TabIndex = 0;
            pieChart.Text = "pieChart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbSumRevenue);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 66);
            panel1.TabIndex = 1;
            // 
            // lbSumRevenue
            // 
            lbSumRevenue.AutoSize = true;
            lbSumRevenue.Location = new Point(165, 20);
            lbSumRevenue.Name = "lbSumRevenue";
            lbSumRevenue.Size = new Size(50, 20);
            lbSumRevenue.TabIndex = 1;
            lbSumRevenue.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 0;
            label3.Text = "Tổng hợp doanh thu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnStatistical);
            panel2.Controls.Add(dtpEnd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpStart);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 71);
            panel2.TabIndex = 0;
            // 
            // btnStatistical
            // 
            btnStatistical.Location = new Point(732, 3);
            btnStatistical.Name = "btnStatistical";
            btnStatistical.Size = new Size(108, 63);
            btnStatistical.TabIndex = 3;
            btnStatistical.Text = "Xem thống kê";
            btnStatistical.UseVisualStyleBackColor = true;
            btnStatistical.Click += btnStatistical_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(447, 20);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 25);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Kết thúc:";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(81, 20);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Bắt đầu:";
            // 
            // fStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 823);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fStatistical";
            Text = "fStatistical";
            WindowState = FormWindowState.Minimized;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Revenue;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel1;
        private Label lbSumRevenue;
        private Label label3;
        private Panel panel2;
        private Button btnStatistical;
        private DateTimePicker dtpEnd;
        private Label label2;
        private DateTimePicker dtpStart;
        private Label label1;
        private LiveCharts.WinForms.PieChart pieChart;
        private Label label4;
    }
}