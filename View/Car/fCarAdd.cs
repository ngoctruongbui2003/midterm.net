using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Repositories;
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
        private readonly ICarRepository _carRepository;

        public fCarAdd(ICarRepository carRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;

            Init();
        }

        public void Init()
        {
            SubData subData = new SubData();
            UploadComboBox(subData.Brands, cbBrand);
            UploadComboBox(subData.Fuels, cbFuel);
            UploadComboBox(subData.Categories, cbCategory);
        }

        private void UploadComboBox(List<string> data, System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (string item in data)
            {
                comboBox.Items.Add(item);
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAdd = _carRepository.Add(new CarModel
            {
                Name = tbName.Text,
                //Image = fileName,
                LicensePlate = tbLicensePlate.Text,
                Description = tbDescription.Text,
                Fuel = cbFuel.SelectedItem.ToString(),
                Brand = cbBrand.SelectedItem.ToString(),
                Category = cbCategory.SelectedItem.ToString(),
                Status = 0
            });

            MessageBox.Show(isAdd == true ? "Thêm xe thành công" : "Thêm xe thất bại");

            Close();
        }

        private void fCarAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
