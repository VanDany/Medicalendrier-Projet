using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DesignWinPatients.ModelesWin;
using Newtonsoft.Json;
using static DesignWinPatients.Variables.VariablesGlobales;
namespace DesignWinPatients
{
    public static class GestionHoraire
    {
        private static HorairesAndLocaux Aconstruire;

        public static async Task<List<HorairesAndLocaux>> GetHoraires(int dureeConsult, List<modwinHorairesPris> rdvList, TimeSpan heureDebut, TimeSpan heureFin, int MaisonMedID, DateTime dateChoisie)
        {
            List<TimeSpan> Horaires = new List<TimeSpan>();
            int duree_consult = dureeConsult;

            TimeSpan totalMinutes = heureFin.Subtract(heureDebut);
            int total = Convert.ToInt32(totalMinutes.TotalMinutes);
            Console.WriteLine("Total en minutes dans l'intervalle = " + total);

            int nb_Slots = total / duree_consult;
            Console.WriteLine("Nombre de slots de rdv = " + nb_Slots);

            TimeSpan consult = TimeSpan.FromMinutes(duree_consult);
            for (int i = 0; i < nb_Slots; i++)
            {
                Horaires.Add(heureDebut);
                heureDebut = heureDebut.Add(consult);
            }

            List<TimeSpan> Acomparer = new List<TimeSpan>();
            for (int i = 0; i < rdvList.Count; i++)
            {
                Acomparer.Add(rdvList[i].Heure_Debut);
            }

            List<TimeSpan> BonsHoraires = new List<TimeSpan>();
            Console.WriteLine("Disponibilités : ");
            bool ok = false;
            for (int i = 0; i < Horaires.Count; i++)
            {
                for (int j = 0; j < Acomparer.Count; j++)
                {
                    if (Horaires[i] == Acomparer[j])
                    {
                        ok = true;
                    }
                }
                if (!ok)
                {
                    BonsHoraires.Add(Horaires[i]);
                }
                ok = false;
            }
            //vérif disponibilités locaux
            string pDate = Convert.ToString(dateChoisie);
            List<modwinPlanningMed> lst = await GetPlanningForLocaux(MaisonMedID, pDate);
            List<modwinLocaux> lstLocaux = await SelectAllLocaux(MaisonMedID);
            List<HorairesAndLocaux> ToSend = new List<HorairesAndLocaux>();

            TimeSpan trancheHorairePlus;
            TimeSpan trancheHoraireMoins;
            int count = 0;
            int idLocalDispo = 0;
            for (int a = 0; a < BonsHoraires.Count; a++)
            {
                idLocalDispo = lstLocaux[0].Local_ID;
                for (int i = 0; i < lst.Count; i++)
                {
                    trancheHorairePlus = lst[i].Heure_Fin.Add(consult);
                    trancheHoraireMoins = lst[i].Heure_Debut.Subtract(consult);
                    List<int> idDejaPris = new List<int>();
                    if (BonsHoraires[a] > trancheHoraireMoins && BonsHoraires[a]+consult < trancheHorairePlus)
                    {
                        count++;
                        idDejaPris.Add(lstLocaux[i].Local_ID);
                    }

                    if (count == lstLocaux.Count)
                    {
                        BonsHoraires.Remove(BonsHoraires[a]);
                    }
                    else
                    {
                        if (idLocalDispo == 0)
                        {
                            idLocalDispo = lstLocaux[i].Local_ID;
                        }
                        for (int k = 0; k < idDejaPris.Count; k++)
                        {
                            if (lstLocaux[k].Local_ID != idDejaPris[k])
                            {
                                idLocalDispo = lstLocaux[k].Local_ID + 1;
                                break;
                            }
                            else
                            {
                                idLocalDispo = lstLocaux[k].Local_ID;
                            }
                        }
                    }
                    count = 0;
                }
                //gestion déjà rendez-vous matin/aprem
                bool fin = false;
                if (DejaRendezVous.Equals("matin"))
                {
                    if (BonsHoraires[a] > TimeSpan.Parse("12:00"))
                    {
                        Aconstruire = new HorairesAndLocaux(BonsHoraires[a], idLocalDispo);
                    }
                    else fin = true;
                }
                if (DejaRendezVous.Equals("aprem"))
                {
                    if (BonsHoraires[a] < TimeSpan.Parse("12:00"))
                    {
                        Aconstruire = new HorairesAndLocaux(BonsHoraires[a], idLocalDispo);
                    }
                    else fin = true;
                }
                else
                {
                    Aconstruire = new HorairesAndLocaux(BonsHoraires[a], idLocalDispo);
                }
                if (!fin)
                    ToSend.Add(Aconstruire);
            }
            return ToSend;
        }
        private static async Task<List<modwinPlanningMed>> GetPlanningForLocaux(int pMaisonMedID, string pDate)
        {
            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Patients/GetPlanningForLocaux";
            var response = await client.GetAsync($"{apiRequest}/?pMaisonMedID={pMaisonMedID}&pDate={pDate}");
            List<modwinPlanningMed> lst = new List<modwinPlanningMed>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinPlanningMed>>(content);
            }
            return lst;
        }
        private static async Task<List<modwinLocaux>> SelectAllLocaux(int MaisonMedID)
        {
            HttpClient client = new HttpClient();
            string apiRequest = "https://localhost:44364/api/Patients/SelectAllLocaux";
            var response = await client.GetAsync($"{apiRequest}/?MaisonMedID={MaisonMedID}");
            List<modwinLocaux> lst = new List<modwinLocaux>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                lst = JsonConvert.DeserializeObject<List<modwinLocaux>>(content);
            }
            return lst;
        }
    } 
    public class HorairesAndLocaux
    {
        public TimeSpan time { get; set; }
        public int IDLocal { get; set; }

        public HorairesAndLocaux(TimeSpan time, int IDLocal)
        {
            this.time = time;
            this.IDLocal = IDLocal;
        }

    }
}
