using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignWinMedecins.Modeles;
using DesignWinMedecins.ModelesWin;
using CustomError;
using DesignWinMedecins.Variables;

namespace DesignWinMedecins
{
    public partial class EncodagePresence : UserControl
    {
        private List<modwinMaisonsMed> lstGlobal = new List<modwinMaisonsMed>();

        public EncodagePresence()
        {
            InitializeComponent();
        }
        private async void EncodagePresence_Load(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            //Maisons Médicales
            string apiRequestMaisonsMed = "https://localhost:44364/api/Medecins/GetMaisonsMed";
            var responseMed = await client.GetAsync(new Uri(apiRequestMaisonsMed));
            if (responseMed.IsSuccessStatusCode)
            {
                string content = responseMed.Content.ReadAsStringAsync().Result;

                List<modwinMaisonsMed> lst = JsonConvert.DeserializeObject<List<modwinMaisonsMed>>(content);
                lstGlobal = lst;
                var noms = new List<string>();
                foreach (modwinMaisonsMed o in lst)
                {
                    noms.Add(o.Nom);
                }

                MaisonMed.DataSource = noms;
            }
        }

        private async void btValider_Click(object sender, EventArgs e)
        {
            int Maison_Med_iD = 0;
            //récupération de la date
            int annee = int.Parse(AnneeTextBox.Text);
            int mois = int.Parse(MoisTextBox.Text);
            int jour = int.Parse(JourTextBox.Text);
            DateTime DatePresence = new DateTime(annee, mois, jour);

            for (int j = 0; j < lstGlobal.Count; j++)
            {
                if (lstGlobal[j].Nom.Equals(MaisonMed.Text))
                {
                    Maison_Med_iD = lstGlobal[j].ID;
                }
            }

            //récupération de l'ID de la maison médicale

            int multirow = 1;
            if (checkNbJours.Checked)
            {
                int nb = Convert.ToInt32(nbJours.Text);
                multirow = nb;
            }
            //Création et envoi de la liste vers API/BL/DB
            try
            {
                TimeSpan heureDebut = TimeSpan.Parse(Heure_Arrivee.Text);
                TimeSpan heureFin = TimeSpan.Parse(Heure_Depart.Text);

                //Check heureDebut/heureFin
                if (heureDebut >= heureFin)
                {
                    Heure_Arrivee.Text = "";
                    Heure_Depart.Text = "";
                    Message("Votre heure de départ ne peut pas être avant votre heure d'arrivée. Veuillez corriger.",
                        "red");
                }
                else
                {
                    DateTime date = Convert.ToDateTime(DatePresence);
                    string dateok = Convert.ToString(DatePresence);
                    List<modwinPresencesMed> AllPresences = await GetAllPresences(VariablesGlobales.Medecin_ID, dateok);
                    List<modwinPresencesMed> presences =
                        DoPresencesList(multirow, Maison_Med_iD, heureFin, heureDebut, date);

                    //verif double présence
                    if (DoublePresence(AllPresences, presences))
                    {
                        Message(
                            "Vous ne pouvez pas être présent dans deux maisons médicales en même temps. Veuillez vérifier vos présences.",
                            "red");
                    }
                    else
                    {
                        try
                        {
                            var content = JsonConvert.SerializeObject(presences);
                            await AddPresences(content);
                            dataGridViewPresences.DataSource = presences;
                            dataGridViewPresences.Columns[0].Visible = false;
                            Message("Les présences demandées ont bien été ajoutées à la base de données.", "green");
                        }
                        catch
                        {
                            Message(
                                "Un problème est survenu lors de l'accès à la base de données.\nVeuillez recommencer, le cas échéant contacter l'administrateur.",
                                "red");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Message("La date est invalide", "red");
            }
        }
        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationPresence.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationPresence.ForeColor = Color.DarkRed;
            }
            ValidationPresence.Text = message;
        }
        private bool DoublePresence(List<modwinPresencesMed> AllPresences, List<modwinPresencesMed> presences)
        {
            for (int i = 0; i < AllPresences.Count; i++)
            {
                for (int j = 0; j < presences.Count; j++)
                {
                    if ((AllPresences[i].Maison_Med_ID != presences[j].Maison_Med_ID) &&
                        (AllPresences[i].Heure_Debut >= presences[j].Heure_Debut &&
                         AllPresences[i].Heure_Debut <= presences[j].Heure_Fin) ||
                        (AllPresences[i].Heure_Fin >= presences[j].Heure_Fin &&
                         AllPresences[i].Heure_Fin <= presences[j].Heure_Debut))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private List<modwinPresencesMed> DoPresencesList(int multirow, int Maison_Med_iD, TimeSpan heureFin, TimeSpan heureDebut, DateTime date)
        {
            List<modwinPresencesMed> presences = new List<modwinPresencesMed>();
            for (int i = 0; i < multirow; i++)
            {
                presences.Add(new modwinPresencesMed()
                {
                    Medecin_ID = VariablesGlobales.Medecin_ID,
                    Maison_Med_ID = Maison_Med_iD,
                    Heure_Fin = heureFin,
                    Heure_Debut = heureDebut,
                    DatePresence = date
                });
                date = date.AddDays(1);
            }

            return presences;
        }

        //****
        //ACCES AUX SP
        //****
        public async Task<List<modwinPresencesMed>> AddPresences(string pPresences)
        {
            HttpClient client = new HttpClient();
            string apiRequestMaisonsMed = "https://localhost:44364/api/Medecins/AddPresences";
            var responseMed = await client.PostAsync(new Uri(apiRequestMaisonsMed),
                new StringContent(pPresences, Encoding.Default, "application/json"));
            List<modwinPresencesMed> lst = new List<modwinPresencesMed>();
            if (responseMed.IsSuccessStatusCode)
            {
                lst = JsonConvert.DeserializeObject<List<modwinPresencesMed>>(pPresences);
            }
            return lst;
        }

        public async Task<List<modwinPresencesMed>> GetAllPresences(int pMedecinID, string pDate)
        {

            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Medecins/GetAllPresences";
            var response = await client.GetAsync($"{apiRequest}/?pMedecinID={pMedecinID}&pDate={pDate}");
            List<modwinPresencesMed> lst = new List<modwinPresencesMed>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinPresencesMed>>(content);
            }
            return lst;
        }
    }
}
