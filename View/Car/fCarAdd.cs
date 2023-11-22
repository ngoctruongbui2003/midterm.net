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
        private ComboBoxData dataCb = new ComboBoxData();

        public fCarAdd(ICarRepository carRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;
        }

        private void fCarAdd_Load(object sender, EventArgs e)
        {
            tbName.Focus();
            Init();
        }

        public void Init()
        {
            ComboBoxData subData = new ComboBoxData();
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

            // 81A-123456
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
            // Check condition when enter invalid
            string name = tbName.Text.Trim();
            string licensePlate = tbLicensePlate.Text.Trim();
            string price = tbPrice.Text.Trim();

            string error = "";
            bool isError = false;

            if (name == "")
            {
                error += "- Bạn chưa nhập tên\n";
                isError = true;
            }
            if (licensePlate == "")
            {
                error += "- Bạn chưa nhập biển số\n";
                isError = true;
            }
            if (price == "")
            {
                error += "- Bạn chưa nhập giá tiền cho thuê\n";
                isError = true;
            }

            if (isError)
            {
                MessageBox.Show(error, "Thông báo");
                return;
            }

            // Add car 
            int isAdd = _carRepository.Add(new CarModel
            {
                Name = name,
                LicensePlate = licensePlate,
                Price = long.Parse(price),
                Description = tbDescription.Text.Trim(),
                Fuel = cbFuel.SelectedItem.ToString(),
                Brand = cbBrand.SelectedItem.ToString(),
                Category = cbCategory.SelectedItem.ToString(),
                Status = dataCb.StatusCar[0]
            });

            MessageBox.Show(isAdd != -1 ? "Thêm xe thành công" : "Thêm xe thất bại");

            // Close
            Close();
        }
    }
}
