using DesignWinAdmin.ModelesWin;
using Newtonsoft.Json;
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

namespace DesignWinAdmin
{
    public partial class AdminPortail : Form
    {
        private List<modwinMaisonsMed> lstGlobal;
        public AdminPortail()
        {
            InitializeComponent();
        }
        private async void AdminPortail_Load(object sender, EventArgs e)
        {
            List<modwinMaisonsMed> lst = await GetMaisonMed();
            lstGlobal = lst;
            for (int i = 0; i < lst.Count; i++)
            {
                MaisonsMed.Items.Add(lst[i].Nom);
            }
        }
        private async void btAjouterMaisonMed_Click(object sender, EventArgs e)
        {
            bool success = await AddMaisonMed(NomTextBox.Text, AdresseTextBox.Text, CommuneTextBox.Text);
            if (!success)
            {
                Message("Un problème est survenu lors de l'ajout de la maison médicale.\nVeuillez recommencer, le cas échéant contacter l'administrateur.", "red");
            }
            else
            {
                MaisonsMed.Items.Clear();
                List<modwinMaisonsMed> lst = await GetMaisonMed();
                for (int i = 0; i < lst.Count; i++)
                {
                    MaisonsMed.Items.Add(lst[i].Nom);
                }
                Message("La maison médicale a bien été ajoutée dans la base de données.", "green");
            }
            
        }
        private async void btAjouterLocal_Click(object sender, EventArgs e)
        {
            int indexMaisonMed = MaisonsMed.SelectedIndex;
            int maisonMedID = lstGlobal[indexMaisonMed].ID;
            bool success = await AddLocal(maisonMedID, nomLocalTextBox.Text);
            if (success == false)
            {
                Message("Un problème est survenu lors de l'ajout du local.\nVeuillez recommencer, le cas échéant contacter l'administrateur.", "red");
            }
            else
            {
                Message("Le local a bien été ajouté dans la base de données.", "green");
            }
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

        private async Task<bool> AddMaisonMed(string pNomMaisonMed, string pAdresse, string pCommune)
        {
            HttpClient client = new HttpClient();
            bool success = false;
            modwinMaisonsMed lst = new modwinMaisonsMed();
            lst.Nom = pNomMaisonMed;
            lst.Adresse = pAdresse;
            lst.Commune = pCommune;
            var content = JsonConvert.SerializeObject(lst);
            string apiRequest = "https://localhost:44364/api/Admin/AddMaisonMed";
            var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                success = true;
            }
            return success;
        }
        private async Task<bool> AddLocal(int pMaisonMedID, string nomLocal)
        {
            HttpClient client = new HttpClient();
            bool success = false;
            modwinLocaux lst = new modwinLocaux();
            lst.Maison_Med_ID = pMaisonMedID;
            lst.NomLocal = nomLocal;
            var content = JsonConvert.SerializeObject(lst);
            string apiRequest = "https://localhost:44364/api/Admin/AddLocal";
            var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                success = true;
            }
            return success;
        }
        private async Task<List<modwinMaisonsMed>> GetMaisonMed()
        {
            HttpClient client = new HttpClient();
            List<modwinMaisonsMed> lst = new List<modwinMaisonsMed>();
            string apiRequest = "https://localhost:44364/api/Medecins/GetMaisonsMed";
            var responseRequest = await client.GetAsync(new Uri(apiRequest));
            if (responseRequest.IsSuccessStatusCode)
            {
                string content = responseRequest.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<modwinMaisonsMed>>(content);
            }
            return lst;
        }


    }
}
