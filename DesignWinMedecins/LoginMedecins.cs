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
using DesignWinMedecins.Modeles;
using DesignWinPatients.UserControl;
using Newtonsoft.Json;
using static DesignWinMedecins.Variables.VariablesGlobales;
namespace DesignWinMedecins
{
    public partial class LoginMedecins : Form
    {
        public LoginMedecins()
        {
            InitializeComponent();
        }

        private void MenuMedecins_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                string apiRequestSpec = "https://localhost:44364/api/Medecins/GetMedByName";
                string pNom = NomTextBox.Text;
                string pPrenom = PrenomTextBox.Text;
                var responseSpec = await client.GetAsync($"{apiRequestSpec}/?pNom={pNom}&pPrenom={pPrenom}");
                if (responseSpec.IsSuccessStatusCode)
                {
                    string content = responseSpec.Content.ReadAsStringAsync().Result;
                    if (content == "null")
                    {
                        MessageBox.Show("Le nom et le prénom ne sont pas connus.");
                    }
                    else
                    {
                        var id = JsonConvert.DeserializeObject<int>(content);
                        Medecin_ID = id;
                        NomMedecin = pNom;
                        PrenomMedecin = pPrenom;
                        TableauPrincipalMedecins newForm = new TableauPrincipalMedecins(NomMedecin, PrenomMedecin);
                        newForm.ShowDialog();
                        this.WindowState = FormWindowState.Minimized;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
