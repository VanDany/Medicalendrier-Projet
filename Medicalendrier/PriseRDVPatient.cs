using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using CustomError;
using DesignWinPatients.ModelesWin;
using Newtonsoft.Json;
using static DesignWinPatients.Variables.VariablesGlobales;

namespace DesignWinPatients
{
    public partial class PriseRDVPatient : System.Windows.Forms.UserControl
    {
        private readonly int _patientid;
        private readonly string _nomMaisonMed;
        private readonly string _nomSpecialite;
        private readonly string _identifiant_Update;
        public PriseRDVPatient()
        {
            InitializeComponent();
        }
        public PriseRDVPatient(int patientid)
        {
            InitializeComponent();
            _patientid = patientid;
        }
        //si c'est un update...
        public PriseRDVPatient(int patientid, string nomMaisonMed, string nomSpecialite, string identifiant_Update)
        {
            InitializeComponent();
            _patientid = patientid;
            _nomMaisonMed = nomMaisonMed;
            _nomSpecialite = nomSpecialite;
            _identifiant_Update = identifiant_Update;
        }
        private async void PriseRDVPatient_Load(object sender, EventArgs e)
        {
            List<modwinMaisonsMed> MaisonsMed = await GetMaisonMed();
            List<string> MaisonsMedNames = new List<string>();

            if (_nomMaisonMed != null && _nomSpecialite != null)
            {
                MaisonMed.Items.Add(_nomMaisonMed);
                Specialite.Items.Add(_nomSpecialite);
            }
            else
            {
                foreach (modwinMaisonsMed o in MaisonsMed)
                {
                    MaisonsMedNames.Add(o.Nom);
                }

                MaisonMed.DataSource = MaisonsMedNames;

                List<modwinSpecialites> Specialites = await GetSpecialites();
                List<string> SpecialitesNames = new List<string>();

                foreach (modwinSpecialites o in Specialites)
                {
                    SpecialitesNames.Add(o.Nom_Specialite);
                }

                Specialite.DataSource = SpecialitesNames;
            }

        }
        private async void btValider_Click(object sender, EventArgs e)
        {
            int pSpecialiteID = 0;
            int pMaisonMedID = 0;
            comboBoxMedecins.DataSource = null;
            comboBoxHoraires.DataSource = null;
            Message("","green");
            BusinessLayer.blPatients o = new blPatients();
            try
            {
                string dateString = JourTextBox.Text + "-" + MoisTextBox.Text + "-" + AnneeTextBox.Text;
                DateTime date = Convert.ToDateTime(dateString);
                if (!champsRemplis())
                {
                    Message("Veuillez compléter tous les champs.", "red");
                }
                else if (o.VerifDatePassee(date))
                {
                    Message("Vous ne pouvez pas prendre un rendez-vous dans le passé !", "red");
                }
                else if (o.VerifDateEgale(date))
                {
                    Message("Vous ne pouvez pas prendre de rendez-vous pour le jour-même.", "red");
                }
                else
                {
                    try
                    {
                        List<modwinSpecialites> Specialites = await GetSpecialites();
                        for (int i = 0; i < Specialites.Count; i++)
                        {
                            if (Specialites[i].Nom_Specialite.Equals(Specialite.Text))
                            {
                                pSpecialiteID = Specialites[i].ID;
                            }
                        }
                    }
                    //si les spécialités n'ont pas pu être récupérées
                    catch (Exception)
                    {
                        throw new MyCustomError(4);
                    }
                    try
                    {
                        List<modwinMaisonsMed> MaisonsMedi = await GetMaisonMed();
                        for (int i = 0; i < MaisonsMedi.Count; i++)
                        {
                            if (MaisonsMedi[i].Nom.Equals(MaisonMed.Text))
                            {
                                pMaisonMedID = MaisonsMedi[i].ID;
                            }
                        }
                    }
                    //si les maisons médicales n'ont pas pu être récupérées
                    catch (Exception)
                    {
                        throw new MyCustomError(5);
                    }

                    //stockage pour la combobox médecin dynamique
                    MaisonMedChoisie = pMaisonMedID;
                    dateChoisie = date;

                    //vérifications
                    var lstVerification = await GetRDVbyPatientID(_patientid, dateString);

                    //si déjà rendez-vous dans une autre maison médicale
                    bool RDVautreMaisonMed = VerifRDVautreMaisonMed(lstVerification);
                    //si déjà rendez-vous dans la maison médicale sélectionnée pour la MEME spécialité
                    bool RDVjourMeme = VerifRDVjourMeme(lstVerification);
                    //si déjà rendez-vous dans la maison médicale sélectionnée pour une AUTRE spécialité
                    bool RDVmemeMaisonMed = VerifRDVmemeMaisonMed(lstVerification);

                    if (RDVautreMaisonMed)
                    {
                        Message(
                            "Désolé, vous avez déjà un rendez-vous dans une autre maison médicale aujourd'hui.",
                            "red");
                    }
                    else if (RDVjourMeme)
                    {
                        Message(
                            "Vous ne pouvez pas prendre un rendez-vous le jour-même dans une même maison médicale pour une même spécialité.",
                            "red");
                    }
                    else
                    {
                        if (RDVmemeMaisonMed)
                        {
                            Message("N'oubliez pas que vous avez déjà un rendez-vous ce jour-là ! Consultez votre agenda.",
                                "red");
                        }
                        //affichage datagridview
                        List<modwinDispo> lst = await GetDispo(dateString, pSpecialiteID, pMaisonMedID);
                        dataGridViewDisponibilites.DataSource = lst;
                        dataGridViewDisponibilites.Columns[3].Visible = false;
                        lstDispo = lst;
                        //liste pour combobox médecin
                        for (int i = 0; i < lst.Count; i++)
                        {
                            modwinMedecins Medecin = await GetMedByID(lst[i].Medecin_ID);
                            comboBoxMedecins.Items.Add(Medecin.Nom + " " + Medecin.Prenom);
                        }
                    }
                }
            }
            catch(FormatException)
            {
                Message("La date est invalide.", "red");
            }
        }
        private async void comboBoxMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMedecins.SelectedIndex != -1)
            {
                List<modwinHorairesPris> RDVdejaPris =
                    await GetHorairesPris(lstDispo[comboBoxMedecins.SelectedIndex].Recap_ID, dateChoisie.ToString());
                modwinPresencesMed PresenceMed = await GetPresences(lstDispo[comboBoxMedecins.SelectedIndex].Medecin_ID,
                    MaisonMedChoisie, dateChoisie.ToString());
                List<HorairesAndLocaux> HorairesOK = await GestionHoraire.GetHoraires(
                    lstDispo[comboBoxMedecins.SelectedIndex].Duree_Consultation, RDVdejaPris, PresenceMed.Heure_Debut,
                    PresenceMed.Heure_Fin, PresenceMed.Maison_Med_ID, dateChoisie);

                List<TimeSpan> lstSource = new List<TimeSpan>();

                for (int i = 0; i < HorairesOK.Count; i++)
                {
                    lstSource.Add(HorairesOK[i].time);
                }

                comboBoxHoraires.DataSource = lstSource;
                HoraireAndLocal = HorairesOK;
            }
        }
        private async void btValiderRDV_Click(object sender, EventArgs e)
        {
            BusinessLayer.blPatients o = new blPatients();
            int PatientID = _patientid;
            int RecapID = lstDispo[comboBoxMedecins.SelectedIndex].Recap_ID;
            DateTime Date = dateChoisie;
            TimeSpan HeureDebut = TimeSpan.Parse(comboBoxHoraires.Text);
            TimeSpan ajout = TimeSpan.FromMinutes(lstDispo[comboBoxMedecins.SelectedIndex].Duree_Consultation);
            TimeSpan HeureFin = TimeSpan.Parse(comboBoxHoraires.Text).Add(ajout);
            int LocalID = 0;
            for (int i = 0; i < HoraireAndLocal.Count; i++)
            {
                if (HoraireAndLocal[i].time == HeureDebut)
                {
                    LocalID = HoraireAndLocal[i].IDLocal;
                }
            }
            //création d'un identifiant aléatoire
            string identifiant = o.IdentifiantAleatoire(comboBoxMedecins.Text);
            //ajout du rendez-vous
            var x = await AddRDV(PatientID, RecapID, Date, HeureDebut, HeureFin, LocalID, identifiant);
            Message("Le rendez-vous a bien été ajouté.\nL'identifiant de votre rendez vous est le : "+identifiant+ ". Notez le bien !", "green");
            //si c'est un update...
            if (_nomMaisonMed != null && _nomSpecialite != null && _identifiant_Update != null)
            {
                bool delete = await DeleteRDVByIdentifiant(_identifiant_Update);
            }
            comboBoxMedecins.Text = null;
            comboBoxHoraires.Text = null;
        }
        private async Task<bool> DeleteRDVByIdentifiant(string pIdentifiant)
        {
            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Patients/DeleteRDVByIdentifiant";
            var responses = await client.DeleteAsync(
                $"{apiRequest}/?pIdentifiant={pIdentifiant}");
            if (responses.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        private bool champsRemplis()
        {
            if (MaisonMed.Text.Length == 0 || Specialite.Text.Length == 0 || JourTextBox.Text.Length == 0 ||
                MoisTextBox.Text.Length == 0 || AnneeTextBox.Text.Length == 0)
            {
                return false;
            }
            else return true;
        }
        private bool VerifRDVautreMaisonMed(List<modwinPlanningMed> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].NomMaisonMed != MaisonMed.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private bool VerifRDVjourMeme(List<modwinPlanningMed> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].NomMaisonMed == MaisonMed.Text &&
                    lst[i].Nom_Specialite == Specialite.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private bool VerifRDVmemeMaisonMed(List<modwinPlanningMed> lst)
        {
            DejaRendezVous = "aucun";
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].NomMaisonMed == MaisonMed.Text &&
                    lst[i].Nom_Specialite != Specialite.Text)
                {
                    if (lst[i].Heure_Debut <= TimeSpan.Parse("12:00"))
                    {
                        DejaRendezVous = "matin";
                    }
                    else DejaRendezVous = "aprem";

                    return true;
                }
            }
            return false;
        }
        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationPriseRDV.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationPriseRDV.ForeColor = Color.DarkRed;
            }
            ValidationPriseRDV.Text = message;
        }

        //**********************
        // METHODES ACCES AUX SP
        //**********************
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

        public async Task<modwinMedecins> GetMedByID(int pID)
        {
            HttpClient client = new HttpClient();
            modwinMedecins lst = new modwinMedecins();
            string apiRequest = "https://localhost:44364/api/Medecins/GetMedByID";
            var response = await client.GetAsync($"{apiRequest}/?pMedecinID={pID}");
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<modwinMedecins>(content);
            }
            return lst;
        }

        public async Task<List<modwinDispo>> GetDispo(string Date, int pSpecialiteID, int pMaisonMedID)
        {
            HttpClient client = new HttpClient();
            string apiRequestDispo = "https://localhost:44364/api/Medecins/GetDispo";
            string pDate = Convert.ToString(Date);
            var response =
                await client.GetAsync(
                    $"{apiRequestDispo}/?pSpecialiteID={pSpecialiteID}&pMaisonMedID={pMaisonMedID}&pDate={pDate}");
            List<modwinDispo> lst = new List<modwinDispo>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinDispo>>(content);
            }
            return lst;
        }

        public async Task<int> GetMedByName(string pNom, string pPrenom)
        {
            HttpClient client = new HttpClient();
            int id = 0;
            string apiRequestSpec = "https://localhost:44364/api/Medecins/GetMedByName";

            var responseSpec = await client.GetAsync($"{apiRequestSpec}/?pNom={pNom}&pPrenom={pPrenom}");
            if (responseSpec.IsSuccessStatusCode)
            {
                string content = responseSpec.Content.ReadAsStringAsync().Result;
                id = JsonConvert.DeserializeObject<int>(content);
            }
            return id;
        }

        public async Task<List<modwinHorairesPris>> GetHorairesPris(int pRecap_ID, string pdate)
        {
            HttpClient client = new HttpClient();
            string apiRequestSpec = "https://localhost:44364/api/Medecins/GetHorairesPris";
            var response = await client.GetAsync($"{apiRequestSpec}/?pRecapID={pRecap_ID}&pDate={pdate}");
            List<modwinHorairesPris> lst = new List<modwinHorairesPris>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinHorairesPris>>(content);
            }
            return lst;
        }

        public async Task<List<modwinPlanningMed>> GetRDVbyPatientID(int pPatientID, string pDate)
        {
            HttpClient client = new HttpClient();
            string apiRequestSpec = "https://localhost:44364/api/Patients/GetRDVbyPatientID";
            var response = await client.GetAsync($"{apiRequestSpec}/?pPatientID={pPatientID}&pDate={pDate}");
            List<modwinPlanningMed> lst = new List<modwinPlanningMed>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinPlanningMed>>(content);
            }
            return lst;
        }

        public async Task<modwinPresencesMed> GetPresences(int pMedecinID, int pMaisonMedID, string pDate)
        {
            HttpClient client = new HttpClient();
            string apiRequestSpec = "https://localhost:44364/api/Patients/GetPresences";
            var response =
                await client.GetAsync(
                    $"{apiRequestSpec}/?pMedecinID={pMedecinID}&pMaisonMedID={pMaisonMedID}&pDate={pDate}");
            modwinPresencesMed lst = new modwinPresencesMed();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<modwinPresencesMed>(content);
            }
            return lst;
        }

        public async Task<modwinRDV> AddRDV(int pPatientID, int pRecapID, DateTime pDate, TimeSpan pHeureDebut,
            TimeSpan pHeureFin, int pLocalID, string pIdentifiant)
        {
            HttpClient client = new HttpClient();
            modwinRDV RDVadded = new modwinRDV();
            RDVadded.Patient_ID = pPatientID;
            RDVadded.Recap_ID = pRecapID;
            RDVadded.Date = pDate;
            RDVadded.Heure_Debut = pHeureDebut;
            RDVadded.Heure_Fin = pHeureFin;
            RDVadded.Local_ID = pLocalID;
            RDVadded.Identifiant_RDV = pIdentifiant;
            var contentRDV = JsonConvert.SerializeObject(RDVadded);
            string apiRequest = "https://localhost:44364/api/Patients/AddRDV";
            var responses = await client.PostAsync(new Uri(apiRequest),
                new StringContent(contentRDV, Encoding.Default, "application/json"));
            if (responses.IsSuccessStatusCode)
            {
                string res = responses.Content.ReadAsStringAsync().Result;

                modwinRDV lst = JsonConvert.DeserializeObject<modwinRDV>(res);
            }
            return RDVadded;
        }
    }
}