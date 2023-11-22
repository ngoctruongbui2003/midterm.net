using Microsoft.Extensions.DependencyInjection;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.Repositories.Impl;
using Midterm_CarRental.View.Customer;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
using System.Windows.Markup;

namespace Midterm_CarRental.View
{
    public partial class fCustomer : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private ComboBoxData dataCb = new ComboBoxData();
        public fCustomer(ICustomerRepository customerRepository)
        {
            InitializeComponent();

            _customerRepository = customerRepository;
        }

        private void LoadAll()
        {
            LoadCustomer();
            LoadButton();
            EnableData(false);
            ClearData();
            LoadComboBox();
        }

        private void LoadCustomer()
        {
            var customers = _customerRepository.GetAll(true);
            LoadCustomerByData(customers);
        }

        private void LoadCustomerByData(List<CustomerMV> customers)
        {
            dgvCustomer.Rows.Clear();

            foreach (var customer in customers)
            {

                dgvCustomer.Rows.Add(new object[]
                {
                    customer.Id,
                    customer.Name,
                    customer.IdentityCard,
                    customer.Gender,
                    customer.Phone,
                    customer.Address,
                });
            }

            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            cbSearch.Items.Clear();

            foreach (string item in dataCb.SearchCustomer)
            {
                cbSearch.Items.Add(item);
            }

            if (cbSearch.Items.Count > 0)
            {
                cbSearch.SelectedIndex = 0;
            }
        }

        private void EnableData(bool isEnable)
        {
            tbName.Enabled = tbIdentityCard.Enabled = tbPhone.Enabled = tbAddress.Enabled =
                rbMan.Enabled = rbWomen.Enabled = isEnable;
        }

        private void ClearData()
        {
            tbId.Clear();
            tbName.Clear();
            tbIdentityCard.Clear();
            tbPhone.Clear();
            tbAddress.Clear();

            rbMan.Checked = true;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            tbId.Enabled = false;
            rbMan.Checked = true;
            LoadAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new fCustomerAdd(_customerRepository);
            f.ShowDialog();
            f = null;
            Show();
            LoadCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvCustomer.SelectedRows[0].Index;
            string id = dgvCustomer.Rows[index].Cells[0].Value.ToString();
            string name = dgvCustomer.Rows[index].Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn xóa khách hàng " + name + "!!",
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool isSuccess = _customerRepository.Delete(Int32.Parse(id));

                MessageBox.Show(isSuccess ? "Bạn đã xóa thành công!" : "Xóa không thành công");

                // Load Form
                LoadAll();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text.Trim();
            int index = cbSearch.SelectedIndex;

            if (index == 0)
            {
                List<CustomerMV> customers = _customerRepository.GetByName(name);
                if (customers == null)
                {
                    LoadCustomer();
                    return;
                }
                LoadCustomerByData(customers);
            }
            else if (index == 1)
            {
                List<CustomerMV> cars = _customerRepository.GetByPhone(name);
                if (cars == null)
                {
                    LoadCustomer();
                    return;
                }
                LoadCustomerByData(cars);
            }
            else if (index == 2)
            {
                List<CustomerMV> cars = _customerRepository.GetByIdentityCard(name);
                if (cars == null)
                {
                    LoadCustomer();
                    return;
                }
                LoadCustomerByData(cars);
            }



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
            string gender = rbMan.Checked ? "Nam" : "Nữ";
            string phone = tbPhone.Text.Trim();
            string identityCard = tbIdentityCard.Text.Trim();
            string address = tbPhone.Text.Trim();

            string error = "";
            bool isError = false;
            if (name == "")
            {
                error += "- Chưa nhập tên\n";
                isError = true;
            }
            if (phone == "")
            {
                error += "- Chưa nhập số điện thoại\n";
                isError = true;
            }
            else if (phone.Length > 10)
            {
                error += "- Số điện thoại quá 10 số";
                isError = true;
            }
            if (identityCard == "")
            {
                error += "- Chưa nhập số căn cước công dân\n";
                isError = true;
            }
            else if (identityCard.Length > 20)
            {
                error += "- Số căn cước công dân quá 20 số";
                isError = true;
            }

            if (isError)
            {
                MessageBox.Show(error, "Thông báo");
                return;
            }

            // Update customer
            CustomerMV customerMV = new CustomerMV()
            {
                Id = Int32.Parse(tbId.Text),
                Name = name,
                Gender = gender,
                Phone = phone,
                IdentityCard = identityCard,
                Address = address,
            };

            _customerRepository.Update(customerMV);

            LoadAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableData(false);
            if (dgvCustomer.CurrentCell == null || dgvCustomer.CurrentCell.Value == null) return;


            btnAdd.Enabled = btnSave.Enabled = false;
            btnUpdate.Enabled = btnDelete.Enabled = true;

            int index = e.RowIndex;

            tbId.Text = dgvCustomer.Rows[index].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString();
            tbIdentityCard.Text = dgvCustomer.Rows[index].Cells[2].Value.ToString();
            string gender = dgvCustomer.Rows[index].Cells[3].Value.ToString();
            if (gender == "Nam")
            {
                rbMan.Checked = true;
            }
            else
            {
                rbWomen.Checked = true;
            }
            tbPhone.Text = dgvCustomer.Rows[index].Cells[4].Value.ToString();
            tbAddress.Text = dgvCustomer.Rows[index].Cells[5].Value.ToString();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                string licenseContextValue = ConfigurationManager.AppSettings["EPPlus:ExcelPackage.LicenseContext"];
                if (!string.IsNullOrEmpty(licenseContextValue))
                {
                    ExcelPackage.LicenseContext = (OfficeOpenXml.LicenseContext)Enum.Parse(typeof(OfficeOpenXml.LicenseContext), licenseContextValue);
                }
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Ngọc Trường Bùi";
                    p.Workbook.Properties.Title = "Export Customer";

                    p.Workbook.Worksheets.Add("Customer List");

                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    ws.Name = "Customer List";
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Time new Roman";

                    string[] arrColumnHeader =
                    {
                        "ID",
                        "Họ và tên",
                        "CCCD",
                        "Giới tính",
                        "Số điện thoại",
                        "Địa chỉ"
                    };

                    var countColHeader = arrColumnHeader.Count();

                    ws.Cells[1, 1].Value = "Danh sách khách hàng";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);

                        var border = cell.Style.Border;
                        border.Bottom.Style = border.Top.Style
                            = border.Right.Style = border.Left.Style = ExcelBorderStyle.MediumDashed;

                        cell.Value = item;

                        colIndex++;
                    }

                    List<CustomerMV> list = _customerRepository.GetAll(false);

                    foreach (var item in list)
                    {
                        colIndex = 1;

                        rowIndex++;

                        ws.Cells[rowIndex, colIndex++].Value = item.Id;
                        ws.Cells[rowIndex, colIndex++].Value = item.Name;
                        ws.Cells[rowIndex, colIndex++].Value = item.IdentityCard;
                        ws.Cells[rowIndex, colIndex++].Value = item.Gender;
                        ws.Cells[rowIndex, colIndex++].Value = item.Phone;
                        ws.Cells[rowIndex, colIndex++].Value = item.Address;
                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }

                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
