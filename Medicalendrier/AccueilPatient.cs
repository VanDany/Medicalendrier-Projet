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
    public partial class AccueilPatient : System.Windows.Forms.UserControl
    {
        private string nom;
        private string prenom;
        private int patientID;
        public AccueilPatient()
        {
            InitializeComponent();
        }
        public AccueilPatient(string nom, string prenom, int patientID)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.patientID = patientID;
            InitializeComponent();
        }
        private void AccueilPatient_Load(object sender, EventArgs e)
        {
            label1.Text = "Bonjour " + prenom + " " + nom + ", bienvenue sur votre espace personnel.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
