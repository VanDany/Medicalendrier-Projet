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
using DesignWinPatients.ModelesWin;
using Newtonsoft.Json;
using static DesignWinPatients.Variables.VariablesGlobales;

namespace DesignWinPatients
{
    public partial class LoginPatient : Form
    {
        public LoginPatient()
        {
            InitializeComponent();
        }

        private async void btEnter_Click(object sender, EventArgs e)
        {
            //validation des champs
            bool valide = champsRemplis();
            if (!valide)
            {
                MessageBox.Show("Veuillez remplir tous les champs pour vous identifier.");
            }
            else
            {
                //récupération des données
                string nom = NomTextBox.Text;
                string prenom = PrenomTextBox.Text;
                int annee = int.Parse(AnneeTextBox.Text);
                int mois = int.Parse(MoisTextBox.Text);
                int jour = int.Parse(JourTextBox.Text);
                DateTime DateDeNaissance = new DateTime(annee, mois, jour);
                string date = DateDeNaissance.ToString();

                //vérification du login
                List<modwinPatient> lst = new List<modwinPatient>();
                lst = await GetPatientsByInfos(nom, prenom, date);
                if (lst.Count == 0)
                {
                    MessageBox.Show("L'utilisateur est inconnu. Veuillez vérifier les informations.");
                }
                //entrée sur le portail
                else
                {
                    int patientID = lst[0].Patient_ID;
                    TableauPrincipalPatient newForm = new TableauPrincipalPatient(nom, prenom, patientID);
                    newForm.ShowDialog();
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }
        //méthodes utilisées
        private async Task<List<modwinPatient>> GetPatientsByInfos(string pNom, string pPrenom, string pDate)
        {
            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Patients/GetPatientByInfos";
            List<modwinPatient> lst = new List<modwinPatient>();
            var response = await client.GetAsync($"{apiRequest}/?pNom={pNom}&pPrenom={pPrenom}&pDate={pDate}");
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<modwinPatient>>(content);
            }
            return lst;
        }
        private bool champsRemplis()
        {
            if (NomTextBox.Text.Length == 0 || PrenomTextBox.Text.Length == 0 || AnneeTextBox.Text.Length == 0 ||
                JourTextBox.Text.Length == 0 || MoisTextBox.Text.Length == 0)
            {
                return false;
            }
            else return true;
        }

        private void LoginPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
