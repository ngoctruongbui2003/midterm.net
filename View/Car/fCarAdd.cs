using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm_CarRental.View.Car
{
    public partial class fCarAdd : Form
    {
        public fCarAdd()
        {
            InitializeComponent();
        }

        private void tbLicensePlate_TextChanged(object sender, EventArgs e)
        {
            string inputText = tbLicensePlate.Text;

            if (inputText.Length == 4)
            {
                if (inputText[3] != '-')
                {
                    string firstPart = inputText.Substring(0, 3);
                    string secondPart = inputText.Substring(3);
                    tbLicensePlate.Text = firstPart + "-" + secondPart;
                    tbLicensePlate.SelectionStart = tbLicensePlate.Text.Length;
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp;)|*.jpg; *.png; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                lbUrl.Text = open.FileName;
                pbCar.Image = new Bitmap(open.FileName);
            }
        }

        private void saveImage()
        {
            File.Copy(lbUrl.Text,
                Path.Combine(@"D:\C# winform\Midterm_CarRental\Resources\Images\",
                Path.GetFileName(lbUrl.Text)), true);
            MessageBox.Show("Save image succecffully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveImage();
        }
    }
}
