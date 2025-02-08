using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Global;
namespace Hospital_Management_System.Appointments
{
    public partial class frmAppointmentInfo : Form
    {
        public frmAppointmentInfo()
        {
            InitializeComponent();
        }

        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            UIHalper.MakeRounded(btnSave, 50);
        }
    }
}
