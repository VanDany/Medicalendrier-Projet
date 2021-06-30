using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomError;
using DesignWinPatients.ModelesWin;
using Newtonsoft.Json;
using static DesignWinPatients.UserControl.ShowUserControl;

namespace DesignWinPatients
{
    public partial class GestionRDVPatients : System.Windows.Forms.UserControl
    {
        private string identifiant;
        private List<modwinGestionRDV> lst = new List<modwinGestionRDV>();
        public GestionRDVPatients()
        {
            InitializeComponent();
        }
        public GestionRDVPatients(int patientID)
        {
            InitializeComponent();
            _patientid = patientID;
        }
        private int _patientid;
        private void GestionRDVPatients_Load(object sender, EventArgs e)
        {

        }

        private async void btValider_Click(object sender, EventArgs e)
        {
            
            var result = await GetRDVbyIdentifiant(textBoxIdentifiant.Text);
           //si échec de la récupération du RDV
            if (result == null)
            {
                Message(
                    "Un problème est survenu lors de la récupération du rendez-vous. Veuillez recommencer, le cas échéant contacter l'administrateur.",
                    "red");
            }
            else
            {
                lst = result;
                identifiant = textBoxIdentifiant.Text;
                dataGridViewGestionRDV.DataSource = result;
                //vérification de l'existence de l'identifiant
                if (result.Count == 0)
                {
                    Message("L'identifiant n'existe pas dans la base de données.", "red");
                }
                else Message("Le rendez-vous a été trouvé : ", "green");
            }
        }

        private async void btDeleteRDV_Click(object sender, EventArgs e)
        {
            if (lst[0].Confirmation == false)
            {
                try
                {
                    bool DeleteRDV = await DeleteRDVByIdentifiant(identifiant);
                    Message("Le rendez-vous a bien été annulé", "green");
                }
                catch(Exception)
                {
                    throw new MyCustomError(2);
                }
                
            }
            //impossibilité d'annuler un rendez-vous confirmé
            else
            {
                Message("Ce rendez-vous a été confirmé, vous ne pouvez plus l'annuler.", "red");
            }
        }
        private void btDeplacerRDV_Click(object sender, EventArgs e)
        {
            if (lst[0].Confirmation == false)
            {
                try
                {
                    PriseRDVPatient newForm = new PriseRDVPatient(_patientid, lst[0].Nom_Maison_Med,
                        lst[0].Nom_Specialite, identifiant);
                    showControl(newForm, MainPanel);
                    newForm.Location = this.Location;
                }
                catch(Exception)
                {
                    throw new MyCustomError(3);
                }
                
            }
            //impossibilité de déplacer un rendez-vous confirmé
            else
            {
                Message("Ce rendez-vous a été confirmé, vous ne pouvez plus le déplacer.", "red");
            }
        }

        public async Task<List<modwinGestionRDV>> GetRDVbyIdentifiant(string Identifiant)
        {
            HttpClient client = new HttpClient();
            string apiRequestSpec = "https://localhost:44364/api/Patients/GetRDVbyIdentifiant";
            var response = await client.GetAsync($"{apiRequestSpec}/?pIdentifiant={Identifiant}");
            List<modwinGestionRDV> lst = new List<modwinGestionRDV>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinGestionRDV>>(content);
            }
            return lst;
        }
        public async Task<bool> DeleteRDVByIdentifiant(string Identifiant)
        {
            HttpClient client = new HttpClient();
            bool success = false;
            string apiRequest = "https://localhost:44364/api/Patients/DeleteRDVByIdentifiant";
            var response = await client.DeleteAsync($"{apiRequest}/?pIdentifiant={Identifiant}");
            if (response.IsSuccessStatusCode)
            {
                success = true;
            }
            return success;
        }
        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationGestionRDV.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationGestionRDV.ForeColor = Color.DarkRed;
            }
            ValidationGestionRDV.Text = message;
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewGestionRDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
