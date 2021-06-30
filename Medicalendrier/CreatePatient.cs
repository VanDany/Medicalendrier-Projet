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

namespace DesignWinPatients
{
    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        private void CreatePatient_Load(object sender, EventArgs e)
        {

        }

        private async void btEnter_Click(object sender, EventArgs e)
        {
            try
            {
                //validation des champs
                if (!champsRemplis())
                {
                    Message("Veuillez remplir tous les champs pour vous identifier.", "red");
                }

                //récupération des données
                modwinPatient patientadded = new modwinPatient();
                patientadded.NomPatient = NomTextBox.Text;
                patientadded.PrenomPatient = PrenomTextBox.Text;

                //conversion de la date en dateTime
                int annee = int.Parse(AnneeTextBox.Text);
                int mois = int.Parse(MoisTextBox.Text);
                int jour = int.Parse(JourTextBox.Text);
                patientadded.Date_De_Naissance = new DateTime(annee, mois, jour);

                //vérification de l'âge
                var age = GetAge(patientadded.Date_De_Naissance);
                if (age < 18)
                {
                    Message("Vous devez être majeur pour créer un compte.", "red");
                }
                else
                {
                    //vérification si le patient n'est pas déjà encodé
                    string date = patientadded.Date_De_Naissance.ToString();
                    List<modwinPatient> lst = await GetPatientsByInfos(NomTextBox.Text, PrenomTextBox.Text, date);
                    if (lst.Count != 0)
                    {
                        Message("Vous avez déjà un compte actif. \nVeuillez vous identifier dans la page de login.", "red");
                    }
                    else
                    {
                        bool ok = await AddPatients(patientadded);
                        //si ajout réussi
                        if (ok)
                        {
                            Message("Le patient a bien été ajouté à la base de données.", "green");
                            LoginPatient newForm = new LoginPatient();
                            newForm.ShowDialog();
                            newForm.Location = this.Location;
                            this.WindowState = FormWindowState.Normal;
                        }
                        //si échec de l'ajout
                        else
                        {
                            Message("Un problème est survenu lors de la création de votre compte. Veuillez recommencer, le cas échéant contacter l'administrateur.", "red");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Message("La date entrée est invalide. Veuillez corriger.", "red");
            }
            catch (Exception)
            {
                throw new MyCustomError(1);
            }
        }
        private async Task<bool> AddPatients(modwinPatient patientAdded)
        {
            HttpClient client = new HttpClient();

            var content = JsonConvert.SerializeObject(patientAdded);
            string apiRequest = "https://localhost:44364/api/Patients/AddPatients";
            var response = await client.PostAsync(new Uri(apiRequest),
                new StringContent(content, Encoding.Default, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
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
        int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
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

        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationAjout.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationAjout.ForeColor = Color.DarkRed;
            }
            ValidationAjout.Text = message;
        }

    }
}
