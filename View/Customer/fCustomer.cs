using Microsoft.Extensions.DependencyInjection;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.View.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CarRental.View
{
    public partial class fCustomer : Form
    {
        private readonly ICustomerRepository _customerRepository;

        public fCustomer(ICustomerRepository customerRepository)
        {
            InitializeComponent();

            _customerRepository = customerRepository;
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            dtgvCustomer.DataSource = null;
            dtgvCustomer.DataSource = _customerRepository.GetAll();
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new fCustomerAdd(Program.ServiceProvider.GetRequiredService<ICustomerRepository>());
            f.ShowDialog();
            LoadCustomer();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string content = tbSearchContent.Text.Trim();

            dtgvCustomer.DataSource = null;
            dtgvCustomer.DataSource = _customerRepository.GetByName(content);
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
