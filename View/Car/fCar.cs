using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.View.Car;
using Midterm_CarRental.View.Customer;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CarRental.View
{
    public partial class fCar : Form
    {
        private readonly ICarRepository _carRepository;
        private ComboBoxData dataCb = new ComboBoxData();
        public fCar(ICarRepository carRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;
        }

        private void LoadAll()
        {
            LoadCar();
            LoadButton();
            EnableData(false);
            ClearData();
            LoadComboBox();
        }

        private void LoadCar()
        {
            var cars = _carRepository.GetAll(true);
            LoadCarByData(cars);
        }

        private void LoadCarByData(List<CarMV> cars)
        {
            dgvCar.Rows.Clear();

            foreach (var car in cars)
            {

                dgvCar.Rows.Add(new object[]
                {
                    car.Id,
                    car.Name,
                    car.LicensePlate,
                    car.Price,
                    car.Description,
                    car.Fuel,
                    car.Brand,
                    car.Category,
                    car.DateAdded,
                    car.Status
                });
            }

            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        }

        private void LoadComboBox()
        {
            UploadComboBox(dataCb.Brands, cbBrand);
            UploadComboBox(dataCb.Fuels, cbFuel);
            UploadComboBox(dataCb.Categories, cbCategory);
            UploadComboBox(dataCb.SearchCar, cbSearch);
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

        private void EnableData(bool isEnable)
        {
            tbName.Enabled = tbLicensePlate.Enabled = tbDescription.Enabled =
                tbPrice.Enabled = cbBrand.Enabled = cbCategory.Enabled = cbFuel.Enabled = isEnable;
        }

        private void ClearData()
        {
            tbId.Clear();
            tbLicensePlate.Clear();
            tbPrice.Clear();
            tbDescription.Clear();
            tbName.Clear();
            tbSearch.Clear();

            cbBrand.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
            cbFuel.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new fCarAdd(_carRepository);
            f.ShowDialog();
            f = null;
            Show();
            LoadCar();
        }

        private void fCar_Load(object sender, EventArgs e)
        {
            tbId.Enabled = false;
            LoadComboBox();
            LoadAll();
        }

        private void dgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableData(false);
            if (dgvCar.CurrentCell == null || dgvCar.CurrentCell.Value == null) return;


            btnAdd.Enabled = btnSave.Enabled = false;
            btnUpdate.Enabled = btnDelete.Enabled = true;

            int index = e.RowIndex;

            tbId.Text = dgvCar.Rows[index].Cells[0].Value.ToString();
            tbName.Text = dgvCar.Rows[index].Cells[1].Value.ToString();
            tbLicensePlate.Text = dgvCar.Rows[index].Cells[2].Value.ToString();
            tbPrice.Text = dgvCar.Rows[index].Cells[3].Value.ToString();
            tbDescription.Text = dgvCar.Rows[index].Cells[4].Value.ToString();

            int indexFuel = dataCb.Fuels.IndexOf(dgvCar.Rows[index].Cells[5].Value.ToString());
            cbFuel.SelectedIndex = indexFuel;

            int indexBrand = dataCb.Brands.IndexOf(dgvCar.Rows[index].Cells[6].Value.ToString());
            cbBrand.SelectedIndex = indexBrand;

            int indexCategory = dataCb.Categories.IndexOf(dgvCar.Rows[index].Cells[7].Value.ToString());
            cbCategory.SelectedIndex = indexCategory;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableData(true);
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            else if (licensePlate.Length > 10)
            {
                error += "- Biển số xe chỉ có 10 kí tự";
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

            // Update car
            CarMV updateCar = new CarMV()
            {
                Id = Int32.Parse(tbId.Text),
                Name = name,
                LicensePlate = licensePlate,
                Price = long.Parse(price),
                Description = tbDescription.Text.Trim(),
                Fuel = cbFuel.SelectedItem.ToString(),
                Brand = cbBrand.SelectedItem.ToString(),
                Category = cbCategory.SelectedItem.ToString(),
            };

            _carRepository.Update(updateCar);

            LoadAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvCar.SelectedRows[0].Index;
            string id = dgvCar.Rows[index].Cells[0].Value.ToString();
            string name = dgvCar.Rows[index].Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn xóa xe " + name + "!!",
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool isSuccess = _carRepository.Delete(Int32.Parse(id));

                MessageBox.Show(isSuccess ? "Bạn đã xóa thành công!" : "Xóa không thành công");

                // Load Form
                LoadAll();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            int index = cb.SelectedIndex;

            if (index != null)
            {
                switch (index)
                {
                    case 0:
                        UploadComboBox(new List<string>()
                        {
                            ""
                        }, cbSearchBy);
                        break;
                    case 1:
                        UploadComboBox(dataCb.Brands, cbSearchBy);
                        break;
                    case 2:
                        UploadComboBox(dataCb.Categories, cbSearchBy);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();
            int index = cbSearch.SelectedIndex;

            if (index == 0)
            {
                List<CarMV> cars = _carRepository.GetByName(name);
                if (cars == null)
                {
                    LoadCar();
                    return;
                }
                LoadCarByData(cars);
            }
            else if (index == 1)
            {
                List<CarMV> cars = _carRepository.GetByBrand(name, cbSearchBy.SelectedItem.ToString());
                if (cars == null)
                {
                    dgvCar.Rows.Clear();
                    return;
                }
                LoadCarByData(cars);
            }
            else if (index == 2)
            {
                List<CarMV> cars = _carRepository.GetByCategory(name, cbSearchBy.SelectedItem.ToString());
                if (cars == null)
                {
                    dgvCar.Rows.Clear();
                    return;
                }
                LoadCarByData(cars);
            }
        }

        private void btnAddExcel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

            openFileDialog.Title = "Chọn file Excel";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            List<CarModel> cars = new List<CarModel>();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string licenseContextValue = ConfigurationManager.AppSettings["EPPlus:ExcelPackage.LicenseContext"];

                // Set the LicenseContext before creating an instance of ExcelPackage
                if (!string.IsNullOrEmpty(licenseContextValue))
                {
                    ExcelPackage.LicenseContext = (OfficeOpenXml.LicenseContext)Enum.Parse(typeof(OfficeOpenXml.LicenseContext), licenseContextValue);
                }

                using (var package = new ExcelPackage(new FileInfo(selectedFilePath)))
                {
                    var workSheet = package.Workbook.Worksheets[0];

                    int rowStart = workSheet.Dimension.Start.Row;
                    int rowEnd = workSheet.Dimension.End.Row;

                    for (int i = rowStart + 1; i <= rowEnd; i++)
                    {
                        try
                        {
                            int j = 1;

                            string name = workSheet.Cells[i, j++].Value.ToString();
                            string licensePlate = workSheet.Cells[i, j++].Value.ToString();
                            string price = workSheet.Cells[i, j++].Value.ToString();
                            string description = workSheet.Cells[i, j++].Value.ToString();
                            string fuel = workSheet.Cells[i, j++].Value.ToString();
                            string brand = workSheet.Cells[i, j++].Value.ToString();
                            string category = workSheet.Cells[i, j++].Value.ToString();

                            cars.Add(new CarModel
                            {
                                Name = name,
                                LicensePlate = licensePlate,
                                Price = long.Parse(price),
                                Description = description,
                                Fuel = fuel,
                                Brand = brand,
                                Category = category,
                                Status = dataCb.StatusCar[0]
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Thêm không thành công");
                        }
                    }
                }
            }

            if (cars != null)
            {
                foreach (var car in cars)
                {
                    _carRepository.Add(car);
                }
            }

            LoadCar();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
