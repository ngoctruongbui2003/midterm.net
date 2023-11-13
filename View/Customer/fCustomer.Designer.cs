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
            tbSearchContent = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnAdd = new Button();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            dtgvCustomer = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // tbSearchContent
            // 
            tbSearchContent.Location = new Point(3, 3);
            tbSearchContent.Name = "tbSearchContent";
            tbSearchContent.PlaceholderText = "Search";
            tbSearchContent.Size = new Size(198, 27);
            tbSearchContent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 69);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(952, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 36);
            panel3.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(tbSearchContent);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 42);
            panel2.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(247, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(34, 29);
            iconButton2.TabIndex = 5;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 24;
            btnSearch.Location = new Point(207, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(34, 29);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(304, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvCustomer);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(1057, 753);
            panel4.TabIndex = 4;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(3, 6);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowHeadersWidth = 51;
            dtgvCustomer.RowTemplate.Height = 29;
            dtgvCustomer.Size = new Size(1049, 743);
            dtgvCustomer.TabIndex = 0;
            // 
            // fCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 822);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "fCustomer";
            Text = "fCustomer";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbSearchContent;
        private Panel panel1;
        private Panel panel3;
        private Button btnAdd;
        private Panel panel2;
        private ComboBox comboBox1;
        private Panel panel4;
        private DataGridView dtgvCustomer;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}