using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CarRental.View.Rent
{
    public partial class fRentInfo : Form
    {
        private readonly ICarRepository _carRepository;
        private readonly IRentRepository _rentRepository;
        private readonly IRentDetailRepository _rentDetailRepository;
        private ComboBoxData dataCb = new ComboBoxData();

        private RentMV rentMV;
        private int dayTotal = 0;
        private long moneyTotal = 0;

        public fRentInfo(RentMV rentMV,
            ICarRepository carRepository,
            IRentRepository rentRepository,
            IRentDetailRepository rentDetailRepository
            )
        {
            InitializeComponent();

            _carRepository = carRepository;
            _rentRepository = rentRepository;
            _rentDetailRepository = rentDetailRepository;


            this.rentMV = rentMV;
            LoadData();
        }
        public fRentInfo(RentMV rentMV,
            IRentRepository rentRepository
            )
        {
            InitializeComponent();

            _rentRepository = rentRepository;
            this.rentMV = rentMV;

            tbPrepaidPrice.Text = rentMV.PrepaidPrice.ToString();
            tbPrepaidPrice.Enabled = false;
            btnAdd.Hide();

            LoadData();
        }

        private void LoadData()
        {


            tbNameCustomer.Text = rentMV.CustomerName.ToString();
            tbPhoneCustomer.Text = rentMV.CustomerPhone.ToString();
            tbIdentityCardCustomer.Text = rentMV.CustomerIdentityCard.ToString();

            tbNameCar.Text = rentMV.CarName.ToString();
            tbLicensePlateCar.Text = rentMV.CarLicensePlate.ToString();

            DateTime pickupdate = Convert.ToDateTime(rentMV.DateRent.Date);
            DateTime dropoffdate = Convert.ToDateTime(rentMV.DateReturn.Date);
            TimeSpan span = dropoffdate.Subtract(pickupdate);
            dayTotal = Convert.ToInt32(Math.Round(span.TotalDays));


            lbString.Text = "Số ngày thuê là:\n";
            lbName.Text = dayTotal + " ngày\n";
            moneyTotal += dayTotal * rentMV.CarPrice;
            lbMoney.Text = moneyTotal.ToString("N0") + "đ\n";


            if (rentMV.Features == null)
            {
                lbString.Text += "Không thêm chức năng cho xe";
                lbName.Text = "";
                return;
            }

            lbString.Text += "Các chức năng:";
            string str = "";
            string strMoney = "";

            foreach (FeatureMV featureMV in rentMV.Features)
            {
                str += featureMV.Name.ToString() + "\n";
                long price = featureMV.Price;
                strMoney += price.ToString("N0") + "đ\n";
                moneyTotal += price;
            }
            lbName.Text += str;
            lbMoney.Text += strMoney;
            lbTotal.Text = moneyTotal.ToString("N0") + "đ";
            if (tbPrepaidPrice.Text == "")
            {
                tbPrepaidPrice.Text = 0 + "";
            }
            else
            {
                moneyTotal -= rentMV.PrepaidPrice;
            }

            lbRemainingMoney.Text = moneyTotal.ToString("N0") + "đ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rentMV.CarStatus.Equals(dataCb.StatusCar[1]))
            {
                MessageBox.Show("Xe đó đã được thuê. Vui lòng chọn xe khác");
                return;
            }
            string remainingMoney = lbRemainingMoney.Text.Replace(",", "").ToString();
            remainingMoney = remainingMoney.Substring(0, remainingMoney.Length - 1);

            long remainMoney = Convert.ToInt64(remainingMoney);

            if (remainMoney < 0)
            {
                MessageBox.Show("Số tiền trả trước nhập chưa đúng");
                return;
            }

            int idRent = _rentRepository.Add(new RentModel()
            {
                DateRent = rentMV.DateRent,
                DateReturn = rentMV.DateReturn,
                PrepaidPrice = Convert.ToInt64(tbPrepaidPrice.Text.ToString()),
                PriceCar = rentMV.CarPrice,
                Status = dataCb.StatusRent[0],
                CustomerId = rentMV.CustomerId,
                CarId = rentMV.CarId
            });

            if (idRent == -1)
            {
                MessageBox.Show("Thêm hóa đơn không thành công!!");
                return;
            }

            foreach (FeatureMV featureMV in rentMV.Features)
            {
                int idRentDetail = _rentDetailRepository.Add(new RentDetailModel()
                {
                    Price = featureMV.Price,
                    RentId = idRent,
                    FeatureId = featureMV.Id
                });

                if (idRentDetail == -1)
                {
                    MessageBox.Show("Thêm hóa đơn không thành công!!");
                    return;
                }
            }

            MessageBox.Show("Thêm hóa đơn thành công!!!");
            bool isChange = _carRepository.ChangeStatusToRent(rentMV.CarId);

            if (!isChange)
            {
                MessageBox.Show("Thay đổi trạng thái xe không thành công");
            }
            Close();
        }

        private void tbPrepaidPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbPrepaidPrice_TextChanged(object sender, EventArgs e)
        {
            string str = tbPrepaidPrice.Text.ToString();
            if (str == "")
            {
                lbRemainingMoney.Text = moneyTotal.ToString("N0") + "đ";
                return;
            }
            long remainingMoney = moneyTotal - Convert.ToInt64(str);
            lbRemainingMoney.Text = remainingMoney.ToString("N0") + "đ";
        }
    }
}
