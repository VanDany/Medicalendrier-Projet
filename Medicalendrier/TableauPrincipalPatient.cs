using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesignWinPatients.UserControl.ShowUserControl;

namespace DesignWinPatients
{
    public partial class TableauPrincipalPatient : Form
    {
        private string nom;
        private string prenom;
        private int patientID;
        public TableauPrincipalPatient()
        {
            InitializeComponent();
        }
        public TableauPrincipalPatient(string nom, string prenom, int patientID)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.patientID = patientID;
            InitializeComponent();
        }
        private void TableauPrincipalPatient_Load(object sender, EventArgs e)
        {
            PictureBox pict = new PictureBox();
            pict.ImageLocation = "../img/choixDocteur.png";
            pict.SizeMode = PictureBoxSizeMode.AutoSize;
            AccueilPatient nouvelAccueil = new AccueilPatient(nom, prenom, patientID);
            showControl(nouvelAccueil, MainPanel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPrendreRDV_Click(object sender, EventArgs e)
        {
            PriseRDVPatient priseRDV = new PriseRDVPatient(patientID);
            showControl(priseRDV, MainPanel);
        }

        private void btGererRDV_Click(object sender, EventArgs e)
        {
            GestionRDVPatients rdv = new GestionRDVPatients(this.patientID);
            showControl(rdv, MainPanel);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
