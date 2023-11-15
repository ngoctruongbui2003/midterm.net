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

            rbMan.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string gender = rbMan.Checked ? "Nam" : "Nữ";
            string phone = tbPhone.Text;
            string identityCard = tbIdentityCard.Text;
            string address = tbPhone.Text;

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
    }
}
