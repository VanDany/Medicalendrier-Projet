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
using DesignWinMedecins.ModelesWin;
using Newtonsoft.Json;
using static DesignWinMedecins.Variables.VariablesGlobales;
namespace DesignWinMedecins
{
    public partial class ConfirmerRDV : UserControl
    {
        public ConfirmerRDV()
        {
            InitializeComponent();
        }
        private async void ConfirmerRDV_Load(object sender, EventArgs e)
        {
            List<modwinPlanningMed> lst = await GetRDVaConfirmer(Medecin_ID);
            dataGridViewConfirmation.DataSource = lst;
        }
        private async void btValider_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            foreach (DataGridViewRow row in dataGridViewConfirmation.SelectedRows)
            {
                string info = row.Cells[10].Value.ToString();
                lst.Add(info);
            }
            //gestion multiples confirmations
            for (int i = 0; i < lst.Count; i++)
            {
                var ok = await Confirmer(lst[i]);
            }
            List<modwinPlanningMed> liste = await GetRDVaConfirmer(Medecin_ID);
            dataGridViewConfirmation.DataSource = liste;
        }

        //****
        //ACCES AUX SP
        //****
        private async Task<List<modwinPlanningMed>> GetRDVaConfirmer(int pMedecinID)
        {
            HttpClient client = new HttpClient();
            List<modwinPlanningMed> lst = new List<modwinPlanningMed>();
            string apiRequest = "https://localhost:44364/api/Medecins/GetRDVaConfirmer";
            var response = await client.GetAsync($"{apiRequest}/?pMedecinID={pMedecinID}");
            if (response.IsSuccessStatusCode)
            {
                string contentMed = response.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<modwinPlanningMed>>(contentMed);
            }
            return lst;
        }
        private async Task<bool> Confirmer(string identifiant)
        {
            HttpClient client = new HttpClient();
            bool success = false;
            string content = JsonConvert.SerializeObject(identifiant);
            string apiRequest = "https://localhost:44364/api/Medecins/AddConfirmation";
            var response = await client.PutAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        private void dataGridViewConfirmation_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
