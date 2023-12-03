using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Data;
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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Midterm_CarRental.View.Rent
{
    public partial class fRentManager : Form
    {
        private readonly IRentRepository _rentRepository;
        private readonly ICarRepository _carRepository;
        private readonly ICustomerRepository _customerRepository;
        public ComboBoxData data = new ComboBoxData();

        private RentMV rentChoosed;
        private int index = -1;

        public fRentManager(IRentRepository rentRepository,
                        ICarRepository carRepository,
                        ICustomerRepository customerRepository)
        {
            InitializeComponent();

            _rentRepository = rentRepository;
            _carRepository = carRepository;
            _customerRepository = customerRepository;

            LoadRent();
        }

        private void LoadRent()
        {
            var rents = _rentRepository.GetAll(true);
            LoadRentByData(rents);
        }

        private void LoadRentByData(List<RentMV> rents)
        {
            dgvRent.Rows.Clear();

            foreach (var rent in rents)
            {

                dgvRent.Rows.Add(new object[]
                {
                    rent.IdRent,
                    rent.CarName,
                    rent.CarLicensePlate,
                    rent.CustomerName,
                    rent.CustomerIdentityCard,
                    rent.CustomerPhone,
                    rent.DateRent,
                    rent.DateReturn,
                    rent.Status
                });
            }

            dgvRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvRent.SelectedRows[0].Index;
                string id = dgvRent.Rows[index].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn xóa hóa đơn có id=" + id,
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = _rentRepository.Delete(Int32.Parse(id));

                    MessageBox.Show(isSuccess ? "Bạn đã xóa thành công!" : "Xóa không thành công");

                    // Load Form
                    LoadRent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }


        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (rentChoosed == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }

            if (dgvRent.Rows[index].Cells["Status"].Value.ToString().Equals(data.StatusRent[1])) {
                MessageBox.Show("Hóa đơn này đã được thanh toán");
                return;
            }

            long remainingPrice = _rentRepository.GetRemainingPriceById(rentChoosed.IdRent);

            MessageBox.Show("Số tiền còn lại phải thanh toán là " + remainingPrice.ToString("N0") + "đ");

            if (MessageBox.Show("Bạn có chắc chắn hóa đơn có id=" + rentChoosed.IdRent + " đã trả xe và thanh toán xong",
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                bool isSuccess = _rentRepository.ChangeStatus(rentChoosed.IdRent);

                MessageBox.Show(isSuccess ? "Trả xe thành công!" : "Trả xe không thành công");

                // Load Form
                LoadRent();
            }
        }

        private void btnRentInfo_Click(object sender, EventArgs e)
        {
            if(rentChoosed == null)
            {
                MessageBox.Show("Chưa chọn hóa đơn để xem");
                return;
            }

            Form f = new fRentInfo(rentChoosed, _rentRepository);
            f.ShowDialog();
            f = null;
            Show();
        }

        private void dgvRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRent.CurrentCell == null || dgvRent.CurrentCell.Value == null) return;

            index = e.RowIndex;
            int id = Int32.Parse(dgvRent.Rows[index].Cells[0].Value.ToString());

            rentChoosed = _rentRepository.GetById(id);
        }

        private void dgvRent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
