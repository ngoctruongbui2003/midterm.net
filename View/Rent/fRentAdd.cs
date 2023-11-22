using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.Repositories.Impl;
using Midterm_CarRental.View.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Midterm_CarRental.View.Rent
{
    public partial class fRentAdd : Form
    {
        private readonly IFeatureRepository _featureRepository;
        private readonly IRentRepository _rentRepository;
        private readonly ICarRepository _carRepository;
        private readonly ICustomerRepository _customerRepository;

        private List<FeatureCheckbox> featureCheckboxes = new List<FeatureCheckbox>();
        private List<FeatureMV> featureChooseds;
        private CustomerMV customerChoosed;
        private CarMV carChoosed;


        public fRentAdd(IFeatureRepository featureRepository,
                        IRentRepository rentRepository,
                        ICarRepository carRepository,
                        ICustomerRepository customerRepository)
        {
            InitializeComponent();
            _featureRepository = featureRepository;
            _rentRepository = rentRepository;
            _carRepository = carRepository;
            _customerRepository = customerRepository;

            featureChooseds = new List<FeatureMV>();

            LoadAll();
        }

        private void LoadFeature()
        {
            List<FeatureMV> features = _featureRepository.GetAll();

            foreach (FeatureMV feature in features)
            {
                AddStringWithCheckbox(feature.Id, feature.Name);
            }

            foreach (var pair in featureCheckboxes)
            {
                pair.CheckBox.Click += Checkbox_Click;
            }

        }

        private void LoadAll()
        {
            tbSearchCar.Clear();
            tbSearchCustomer.Clear();
            dtpDateReturn.Value = DateTime.Now;

            LoadData();
        }

        private void LoadData()
        {
            LoadCar();
            LoadFeature();
            LoadCustomer();
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

        private void Checkbox_Click(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            int id = Int32.Parse(GetIdFromCheckbox(clickedCheckbox));

            featureChooseds.Add(_featureRepository.GetById(id));
        }

        private string GetIdFromCheckbox(CheckBox checkbox)
        {
            var pair = featureCheckboxes.Find(p => p.CheckBox == checkbox);

            return pair.Id.ToString();
        }

        private void AddStringWithCheckbox(int id, string name)
        {
            CheckBox checkBox = new CheckBox();

            FeatureCheckbox dataFeature = new FeatureCheckbox
            {
                Id = id,
                Name = name,
                CheckBox = checkBox
            };

            featureCheckboxes.Add(dataFeature);
            checkBox.Text = name;

            flpFeature.Controls.Add(checkBox);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (FeatureCheckbox featureCheckbox in featureCheckboxes)
            {
                if (featureCheckbox.CheckBox.Checked)
                {
                    MessageBox.Show($"111Clicked checkbox with Id: {featureCheckbox.Name}");
                }
            }
        }

        private void btnInfoPrice_Click(object sender, EventArgs e)
        {
            DateTime pickupdate = DateTime.Now.Date;
            DateTime dropoffdate = Convert.ToDateTime(dtpDateReturn.Value.Date);
            TimeSpan span = dropoffdate.Subtract(pickupdate);
            int daysTotal = Convert.ToInt32(Math.Round(span.TotalDays));

            string error = "";
            bool isError = false;

            if (carChoosed == null)
            {
                error += "- Chưa chọn xe để thuê\n";
                isError = true;
            }
            if (customerChoosed == null)
            {
                error += "- Chưa chọn khách hàng thuê xe\n";
                isError = true;
            }
            if (daysTotal <= 0)
            {
                error += "- Ngày thuê phải nhỏ hơn hoặc bằng ngày trả";
                isError = true;
            }

            if (isError)
            {
                MessageBox.Show(error);
                return;
            }

            Form f = new fRentInfo(new RentMV()
            {
                DateRent = pickupdate,
                DateReturn = dropoffdate,
                CustomerId = customerChoosed.Id,
                CustomerName = customerChoosed.Name,
                CustomerPhone = customerChoosed.Phone,
                CustomerIdentityCard = customerChoosed.IdentityCard,
                CarId = carChoosed.Id,
                CarName = carChoosed.Name,
                CarLicensePlate = carChoosed.LicensePlate,
                CarPrice = carChoosed.Price,
                CarStatus = carChoosed.Status,
                Features = featureChooseds
            },
                _carRepository,
                _rentRepository,
                Program.ServiceProvider.GetRequiredService<IRentDetailRepository>());


            f.ShowDialog();
            f = null;

            Show();
        }

        private void dgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Int32.Parse(dgvCar.Rows[index].Cells[0].Value.ToString());

            carChoosed = _carRepository.GetById(id);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Int32.Parse(dgvCustomer.Rows[index].Cells[0].Value.ToString());

            customerChoosed = _customerRepository.GetById(id);
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            string name = tbSearchCar.Text.Trim();

            List<CarMV> cars = _carRepository.GetByName(name);
            if (cars == null)
            {
                LoadCustomer();
                return;
            }
            LoadCarByData(cars);
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = tbSearchCustomer.Text.Trim();

            List<CustomerMV> customers = _customerRepository.GetByName(name);
            if (customers == null)
            {
                LoadCustomer();
                return;
            }
            LoadCustomerByData(customers);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}
