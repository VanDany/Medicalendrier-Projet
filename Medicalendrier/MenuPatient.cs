using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignWinPatients
{
    public partial class MenuPatient : Form
    {
        public MenuPatient()
        {
            InitializeComponent();
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            CreatePatient newForm = new CreatePatient();
            newForm.ShowDialog();
            newForm.Location = this.Location;
            this.WindowState = FormWindowState.Normal;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginPatient newForm = new LoginPatient();
            newForm.ShowDialog();
            newForm.Location = this.Location;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
