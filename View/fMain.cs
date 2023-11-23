using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.View.Bill;
using Midterm_CarRental.View.Rent;
using Midterm_CarRental.View.Statistical;
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
    public partial class fMain : Form
    {
        bool isExit = true;
        IconButton currentBtn;
        Form activeForm;

        public fMain(bool isAdmin, string displayName)
        {
            InitializeComponent();

            if (!isAdmin)
            {
                btnStatisticalForm.Hide();
            }

            lbHello.Text = displayName;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnDesktopPane.Controls.Add(childForm);
            pnDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (IconButton)btnSender)
                {
                    DisableButton();
                }
                currentBtn = (IconButton)btnSender;
                currentBtn.BackColor = Color.FromArgb(0, 0, 255); ;
                currentBtn.ForeColor = Color.White;

                iconChildForm.IconChar = currentBtn.IconChar;
                lbChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void btnCarForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCar(Program.ServiceProvider.GetRequiredService<ICarRepository>()), sender);
        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCustomer(Program.ServiceProvider.GetRequiredService<ICustomerRepository>()), sender);
        }

        private void btnRentForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fRentAdd(
                Program.ServiceProvider.GetRequiredService<IFeatureRepository>(),
                Program.ServiceProvider.GetRequiredService<IRentRepository>(),
                Program.ServiceProvider.GetRequiredService<ICarRepository>(),
                Program.ServiceProvider.GetRequiredService<ICustomerRepository>()),
                sender);
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fRentManager(Program.ServiceProvider.GetRequiredService<IRentRepository>(),
                Program.ServiceProvider.GetRequiredService<ICarRepository>(),
                Program.ServiceProvider.GetRequiredService<ICustomerRepository>()), sender);
        }

        private void btnStatisticalForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fStatistical(Program.ServiceProvider.GetRequiredService<IRentRepository>()), sender);
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit == true)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isExit = false;
            Close();
        }
    }
}
