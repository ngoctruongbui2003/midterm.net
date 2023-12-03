using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CarRental.View.Customer
{
    public partial class fCustomerAdd : Form
    {
        private readonly ICustomerRepository _customerRepository;

        public fCustomerAdd(ICustomerRepository customerRepository)
        {
            InitializeComponent();

            _customerRepository = customerRepository;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string gender = rbMan.Checked ? "Nam" : "Nữ";
            string phone = tbPhone.Text.Trim();
            string identityCard = tbIdentityCard.Text.Trim();
            string address = tbAddress.Text.Trim();

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

            _customerRepository.Add(new CustomerModel

            {
                Name = name,
                Gender = gender,
                Phone = phone,
                IdentityCard = identityCard,
                Address = address
            });

            MessageBox.Show("Thêm khách hàng thành công");
            Close();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void tbIdentityCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void fCustomerAdd_Load(object sender, EventArgs e)
        {
            rbMan.Checked = true;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void onlyNumber(object sender, KeyPressEventArgs e)
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
    }
}
