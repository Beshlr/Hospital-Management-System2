using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Login;
using Hospital_Management_System.Classes;

using Hospital_Management_System.Properties;
using Hospital_Management_System.Appointments;

namespace Hospital_Management_System
{
    public partial class frmMainForSecretary : Form
    {
        frmLoginScreen _frmLogin;

        public frmMainForSecretary(frmLoginScreen LoginFrm)
        {
            InitializeComponent();
            _frmLogin = LoginFrm;
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnlSubMenuGeneral.Visible = false;
            pnlSubMenuStaf.Visible = false;
            pnlSubMenuPharmacy.Visible = false;
        }

        private void showSubMenu(Guna.UI2.WinForms.Guna2Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuGeneral);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuStaf);

        }

       

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuPharmacy);

        }

        private Form activeForm = null;

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Dispose(); 
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            if (activeForm is frmAppointmentsList)
                return;

            openChildFormInPanel(new frmAppointmentsList());
            hideSubMenu();
        }

        private void frmMainForSecretary_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.ImagePath != null && clsGlobal.CurrentUser.ImagePath.Length > 0)
                pbxUserImage.ImageLocation = clsGlobal.CurrentUser.ImagePath;
            lblUsername.Text = clsGlobal.CurrentUser.UserName;
        }

        private bool _KeepPanelVisable = false;

        private void pbxUserImage_Click(object sender, EventArgs e)
        {
            
        }

        

        private void pnlLoginUserEdit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxUserImage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
