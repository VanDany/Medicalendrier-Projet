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
using DesignWinMedecins.ModelesWin;
using Modeles;
using Newtonsoft.Json;
using static DesignWinMedecins.Variables.VariablesGlobales;
namespace DesignWinMedecins
{
    public partial class ChangerLienAssociation : UserControl
    {
        private bool lienActif = true;
        private List<modwinMMS> liste = new List<modwinMMS>();
        public ChangerLienAssociation()
        {
            InitializeComponent();
        }
        private async void ChangerLienAssciation_Load(object sender, EventArgs e)
        {
            try
            {
                liste = await GetMMSByMedID(Medecin_ID);
            }
            catch (Exception)
            {
                throw new MyCustomError(6);
            }
            dataGridViewAssociation.DataSource = liste;
        }
        private void dataGridViewAssociation_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridViewAssociation.SelectedRows)
            {
                string info = row.Cells[5].Value.ToString();
                lienActif = Convert.ToBoolean(info);
            }
            if (lienActif)
                btActiverOuDesactiver.Text = "Désactiver l'association";
            else btActiverOuDesactiver.Text = "Activer l'association";
        }
        private async void btActiverOuDesactiver_Click(object sender, EventArgs e)
        {
            bool toSend;
            if (lienActif)
                toSend = false;
            else toSend = true;
            var ok = await ChangeLien(toSend, liste[dataGridViewAssociation.SelectedRows[0].Index].Recap_ID);
            liste = await GetMMSByMedID(Medecin_ID);
            dataGridViewAssociation.DataSource = liste;
        }
        //****
        //ACCES AUX SP
        //****
        private async Task<List<modwinMMS>> GetMMSByMedID(int pMedecinID)
        {
            HttpClient client = new HttpClient();
            List<modwinMMS> lst = new List<modwinMMS>();
            string apiRequest = "https://localhost:44364/api/Medecins/GetMMSbyMedID";
            var response = await client.GetAsync($"{apiRequest}/?pMedecinID={pMedecinID}");
            if (response.IsSuccessStatusCode)
            {
                string contentMed = response.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<modwinMMS>>(contentMed);
            }
            return lst;
        }
        private async Task<bool>ChangeLien(bool pLienActif, int pRecapID)
        {
            HttpClient client = new HttpClient();
            modwinLienActif ToSend = new modwinLienActif();
            ToSend.LienActif = pLienActif;
            ToSend.RecapID = pRecapID;
            var content = JsonConvert.SerializeObject(ToSend);
            string apiRequest = "https://localhost:44364/api/Medecins/AddLien";
            var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
