using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesignWinMedecins.Variables.VariablesGlobales;

namespace DesignWinMedecins
{
    public partial class MenuMedecin : UserControl
    {
        public MenuMedecin()
        {
            InitializeComponent();
        }

        private void MenuMedecins_Load(object sender, EventArgs e)
        {
            AccueilMedecin.Text = "Bonjour " + NomMedecin + " " + PrenomMedecin +
                                  ", bienvenue sur votre espace personnel.";
        }

        private void btEncoderPresences_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            EncodagePresence newForm = new EncodagePresence();
        }

        private void btAssociation_Click(object sender, EventArgs e)
        {
            AssociationMedConsult newForm = new AssociationMedConsult();
        }

        private void btPlanning_Click(object sender, EventArgs e)
        {
            Planning newForm = new Planning();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmerRDV newForm = new ConfirmerRDV();
        }

        private void btAnnulerAssociation_Click(object sender, EventArgs e)
        {
            ChangerLienAssociation newForm = new ChangerLienAssociation();
        }
    }
}

