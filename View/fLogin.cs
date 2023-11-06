using Midterm_CarRental.Repositories;
using Midterm_CarRental.View;

namespace Midterm_CarRental
{
    public partial class fLogin : Form
    {
        private readonly IAccountRepository _accountRepository;

        public fLogin(IAccountRepository accountRepository)
        {
            InitializeComponent();
            this._accountRepository = accountRepository;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string password = tbPassword.Text;

            int role = _accountRepository.isLogin(userName, password);

            if (role == -1)
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

            string displayName = _accountRepository.GetDisplayName(userName);

            Form fMain = new fMain(role == 1 ? true : false, displayName);
            this.Hide();
            fMain.ShowDialog();

            tbUsername.Focus();
            tbUsername.Text = "";
            tbPassword.Text = "";

            this.Show();
        }
    }
}