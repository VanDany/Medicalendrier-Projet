using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignWinMedecins
{
    public partial class AccueilMedecin : UserControl
    {
        private string nom;
        private string prenom;
        public AccueilMedecin()
        {
            InitializeComponent();
        }
        public AccueilMedecin(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
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
