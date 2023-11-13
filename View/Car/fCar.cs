using Microsoft.Extensions.DependencyInjection;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.View.Car;
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
    public partial class fCar : Form
    {
        private readonly ICarRepository _carRepository;

        public fCar(ICarRepository carRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;

            LoadCar();
        }

        private void LoadCar()
        {
            dgvCar.DataSource = null;

            var cars = _carRepository.GetAll(true);
            string status = "";
            Image img;

            foreach (var car in cars)
            {
                
                if (car.Status == 0)
                {
                    status = "Trống";
                } else
                {
                    status = "Đang thuê";
                }


                MessageBox.Show(Directory.GetCurrentDirectory() + @"..\..\..\Resources\Images");

                dgvCar.Rows.Add(new object[]
                {
                    car.Id,
                    car.Name,
                    car.Image,
                    car.LicensePlate,
                    car.Description,
                    car.Fuel,
                    car.Brand,
                    car.Category,
                    car.DateAdded,
                    status
                });
            }

            dgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new fCarAdd(_carRepository);
            f.ShowDialog();
            this.Show();

            LoadCar();
        }
    }
}
