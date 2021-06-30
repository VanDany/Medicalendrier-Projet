using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomError;
using DesignWinMedecins.Modeles;
using DesignWinMedecins.ModelesWin;
using Newtonsoft.Json;

namespace DesignWinMedecins
{
    public partial class AssociationMedConsult : UserControl
    {
        private List<modwinMaisonsMed> lstGlobalMM = new List<modwinMaisonsMed>();
        private List<modwinSpecialites> lstGlobalS = new List<modwinSpecialites>();
        public AssociationMedConsult()
        {
            InitializeComponent();
        }

        private async void AssociationMedConsult_Load(object sender, EventArgs e)
        {
            try
            {
                var listeS = await GetSpecialites();
                lstGlobalS = listeS;
                var noms = new List<string>();
                foreach (modwinSpecialites o in listeS)
                {
                    noms.Add(o.Nom_Specialite);
                }

                ComboBoxSpecialite.DataSource = noms;
            }
            catch (Exception)
            {
                throw new MyCustomError(4);
            }
            try
            {
                var listeM = await GetMaisonMed();
                lstGlobalMM = listeM;
                var noms2 = new List<string>();
                foreach (modwinMaisonsMed o in listeM)
                {
                    noms2.Add(o.Nom);
                }

                ComboBoxMaisonMed.DataSource = noms2;
            }
            catch (Exception)
            {
                throw new MyCustomError(5);
            }

        }
        private async void btAssociation_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            //Add MMS
            modwinMMS MMSadded = new modwinMMS();
            MMSadded.Medecin_ID = Variables.VariablesGlobales.Medecin_ID;
            MMSadded.Specialite_ID = FindIDSpecialites(lstGlobalS);
            MMSadded.Maison_Med_ID = FindIDMaisonsMed(lstGlobalMM);
            MMSadded.Duree_Consultation = Convert.ToInt32(ComboBoxDureeConsult.Text);
            MMSadded.Verif_Lien = true;
            var contentMMS = JsonConvert.SerializeObject(MMSadded);

            string apiRequestMMS = "https://localhost:44364/api/Medecins/AddMMS";
            var responsesMMS = await client.PostAsync(new Uri(apiRequestMMS), new StringContent(contentMMS, Encoding.Default, "application/json"));
            if (!responsesMMS.IsSuccessStatusCode)
            {
                Message(
                    "Un problème est survenu lors de l'accès à la base de données. Veuillez recommencer, le cas échéant contacter l'administrateur.",
                    "red");
            }
            else Message("L'association entre la spécialité, la maison médicale et la durée de consultation a bien été effectuée.", "green");
        }

        public int FindIDSpecialites(List<modwinSpecialites> Lambda)
        {
            for (int j = 0; j < Lambda.Count; j++)
            {
                if (Lambda[j].Nom_Specialite.Equals(ComboBoxSpecialite.Text))
                {
                    return Lambda[j].ID;
                }
            }
            return 0;
        }
        public int FindIDMaisonsMed(List<modwinMaisonsMed> Lambda)
        {
            for (int j = 0; j < Lambda.Count; j++)
            {
                if (Lambda[j].Nom.Equals(ComboBoxMaisonMed.Text))
                {
                    return Lambda[j].ID;
                }
            }
            return 0;
        }
        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationAssociation.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationAssociation.ForeColor = Color.DarkRed;
            }
            ValidationAssociation.Text = message;
        }
        //****
        //ACCES AUX SP
        //****
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

        private async Task<List<modwinSpecialites>> GetSpecialites()
        {
            HttpClient client = new HttpClient();
            List<modwinSpecialites> lst = new List<modwinSpecialites>();
            string apiRequest = "https://localhost:44364/api/Medecins/GetSpecialites";
            var responseRequest = await client.GetAsync(new Uri(apiRequest));
            if (responseRequest.IsSuccessStatusCode)
            {
                string content = responseRequest.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<modwinSpecialites>>(content);
            }
            return lst;
        }

    }
    
}
