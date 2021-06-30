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

namespace DesignWinMedecins
{
    public partial class TableauPrincipalMedecins : Form
    {
        private string nom;
        private string prenom;
        public TableauPrincipalMedecins()
        {
            InitializeComponent();
        }
        public TableauPrincipalMedecins(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            InitializeComponent();
        }
        private void TableauPrincipalPatient_Load(object sender, EventArgs e)
        {
            PictureBox pict = new PictureBox();
            pict.ImageLocation = "../img/choixDocteur.png";
            pict.SizeMode = PictureBoxSizeMode.AutoSize;
            AccueilMedecin nouvelAccueil = new AccueilMedecin(nom, prenom);
            showControl(nouvelAccueil, MainPanel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btPlanning_Click(object sender, EventArgs e)
        {
            Planning plan = new Planning();
            showControl(plan, MainPanel);
        }
        private void btRDV_Click(object sender, EventArgs e)
        {
            ConfirmerRDV rdv = new ConfirmerRDV();
            showControl(rdv, MainPanel);
        }
        private void btPresences_Click(object sender, EventArgs e)
        {
            EncodagePresence pres = new EncodagePresence();
            showControl(pres, MainPanel);
        }
        private void btAssocier_Click(object sender, EventArgs e)
        {
            AssociationMedConsult assoc = new AssociationMedConsult();
            showControl(assoc, MainPanel);
        }
        private void btChangerAssociation_Click(object sender, EventArgs e)
        {
            ChangerLienAssociation changer = new ChangerLienAssociation();
            showControl(changer, MainPanel);
        }
    }
}
