using DesignWinMedecins.Modeles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesignWinMedecins.Variables.VariablesGlobales;

namespace DesignWinMedecins
{
    public partial class Planning : UserControl
    {
        public Planning()
        {
            InitializeComponent();
        }

        private async void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                int annee = int.Parse(AnneeTextBox.Text);
                int mois = int.Parse(MoisTextBox.Text);
                int jour = int.Parse(JourTextBox.Text);
                DateTime Date = new DateTime(annee, mois, jour);
                string date = Date.ToString();
                try
                {
                    List<modwinPlanningMed> lst = await GetPlanning(Medecin_ID, date);
                    dataGridViewPlanning.DataSource = lst;
                    dataGridViewPlanning.Columns[0].Visible = false;
                }
                catch(Exception)
                {
                    Message("Un problème est survenu lors de la récupération de votre planning. Veuillez recommencer, le cas échéant contacter l'administrateur", "red");
                }
            }
            catch (FormatException)
            {
                Message("La date n'est pas valide", "red");
            }
        }
        private void Message(string message, string couleur)
        {
            if (couleur == "green")
            {
                ValidationPlanning.ForeColor = Color.LimeGreen;
            }
            else if (couleur == "red")
            {
                ValidationPlanning.ForeColor = Color.DarkRed;
            }
            ValidationPlanning.Text = message;
        }
        //****
        //ACCES AUX SP
        //****
        private async Task<List<modwinPlanningMed>> GetPlanning(int pMedecinID, string pDate)
        {
            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Medecins/GetPlanning";
            var response = await client.GetAsync($"{apiRequest}/?pMedecinID={pMedecinID}&pDate={pDate}");
            List<modwinPlanningMed> lst = new List<modwinPlanningMed>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                
                lst = JsonConvert.DeserializeObject<List<modwinPlanningMed>>(content);
            }
            return lst;
        }

        private void Planning_Load(object sender, EventArgs e)
        {

        }
    }
}
