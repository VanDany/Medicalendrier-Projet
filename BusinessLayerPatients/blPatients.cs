using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DALEF;
using Modeles;
using Newtonsoft.Json;

namespace BusinessLayer
{
    public class blPatients
    {
        public bool VerifDatePassee(DateTime date)
        {
            if (date < DateTime.Today)
            {
                return true;
            }
            return false;
        }
        public bool VerifDateEgale(DateTime date)
        {
            if (date == DateTime.Today)
            {
                return true;
            }
            return false;
        }
        public string IdentifiantAleatoire(string comboBoxText)
        {
            Random rnd = new Random();
            int aleatoire = rnd.Next(10000, 99999);
            string s = comboBoxText.Substring(0, 2);
            return s + aleatoire;
        }
        public string Patients_All()
        {
            DALEF.EFPatients cx = new EFPatients();
            List<DALEF.SelectAllPatients_Result> lst = cx.SelectAll();

            List<Modeles.modPatients> lstPatients = new List<modPatients>();
            foreach (DALEF.SelectAllPatients_Result o in lst)
            {
                Modeles.modPatients oPatients = new modPatients();
                oPatients.Patient_ID = o.Patient_ID;
                oPatients.NomPatient = o.NomPatient;
                oPatients.PrenomPatient = o.PrenomPatient;
                oPatients.Date_De_Naissance = o.Date_de_naissance;
                oPatients.Identifiant_ID = o.Identifiant_ID;

                lstPatients.Add(oPatients);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstPatients);
            return sJsonToReturn;
        }

        public string MaisonsMed_All()
        {
            DALEF.EFPatients cx = new EFPatients();
            List<DALEF.SelectAllMaisonMed_Result> lst = cx.SelectAllMaisonsMed();

            List<Modeles.modMaisonsMed> lstPatients = new List<modMaisonsMed>();
            foreach (DALEF.SelectAllMaisonMed_Result o in lst)
            {
                Modeles.modMaisonsMed oMaisonsMed = new modMaisonsMed();
                oMaisonsMed.ID = o.Maison_Med_ID;
                oMaisonsMed.Nom = o.Nom;
                oMaisonsMed.Adresse = o.Adresse;
                oMaisonsMed.Commune = o.Commune;

                lstPatients.Add(oMaisonsMed);
            }

            string sJsonToReturn = JsonConvert.SerializeObject(lstPatients, Formatting.Indented);
            return sJsonToReturn;
        }

        public string Specialites_All()
        {
            DALEF.EFPatients cx = new EFPatients();
            List<DALEF.SelectAllSpecialites_Result> lst = cx.SelectAllSpecialites();

            List<Modeles.modSpecialites> lstPatients = new List<modSpecialites>();
            foreach (DALEF.SelectAllSpecialites_Result o in lst)
            {
                Modeles.modSpecialites oSpecialites = new modSpecialites();
                oSpecialites.ID = o.Specialite_ID;
                oSpecialites.Nom_Specialite = o.Nom_Specialite;

                lstPatients.Add(oSpecialites);
            }

            string sJsonToReturn = JsonConvert.SerializeObject(lstPatients, Formatting.Indented);
            return sJsonToReturn;
        }

        public string GetPresences(int pMedecinID, int pMaisonMedID, string pDate)
        {
            DALEF.EFPatients cx = new EFPatients();
            SelectPresencesByMed_Result lst = cx.GetPresences(pMedecinID, pMaisonMedID, pDate);

            string sJsonToReturn = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return sJsonToReturn;
        }
        public string GetPlanningForLocaux(int pMaisonMedID, string pDate)
        {
            DALEF.EFPatients cx = new EFPatients();
            List<SelectRDVforLocaux_Result> lst = cx.GetRDVforLocaux(pMaisonMedID, pDate);

            string sJsonToReturn = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return sJsonToReturn;
        }

        public string GetRDVByPatientID(int pPatientID, string pDate)
        {
            DALEF.EFPatients cx = new EFPatients();
            List<SelectRDVByPatientID_Result> lst = cx.GetRDVByPatientID(pPatientID, pDate);

            string sJsonToReturn = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return sJsonToReturn;
        }
        public string GetRDVByIdentifiant(string pIdentifiant)
        {
            DALEF.EFPatients cx = new EFPatients();
            List<SelectRDVByIdentifiant_Result> lst = cx.GetRDVByIdentifiant(pIdentifiant);
            List<Modeles.modGestionRDV> lstRDV = new List<modGestionRDV>();
            foreach (DALEF.SelectRDVByIdentifiant_Result o in lst)
            {
                Modeles.modGestionRDV oRDV= new modGestionRDV();
                oRDV.Date = o.Date;
                oRDV.Heure_Debut = o.Heure_Debut;
                oRDV.Heure_Fin = o.Heure_Fin;
                oRDV.Nom_Patient = o.Nom_Patient;
                oRDV.Prenom_Patient = o.Prenom_Patient;
                oRDV.Nom_Maison_Med = o.Nom_Maison_Med;
                oRDV.Adresse = o.Adresse;
                oRDV.Nom_Medecin = o.Nom_Medecin;
                oRDV.Prenom_Medecin = o.Nom_Medecin;
                oRDV.Nom_Specialite = o.Nom_Specialite;
                oRDV.Confirmation = o.Confirmation;

                lstRDV.Add(oRDV);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstRDV, Formatting.Indented);
            return sJsonToReturn;
        }


        public string GetPatientByInfos(string pNom, string pPrenom, string pDate)
        {
            DALEF.EFPatients cx = new EFPatients();
            List<GetPatientByInfos_Result> lst = new List<GetPatientByInfos_Result>(); 
            lst = cx.GetPatientByInfos(pNom, pPrenom, pDate);
            string sJsonToReturn = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return sJsonToReturn;
        }
        public string SelectAllLocaux(int MaisonMedID)
        {
            DALEF.EFPatients cx = new EFPatients();
            List<SelectAllLocaux_Result> lst = cx.SelectAllLocaux(MaisonMedID);
            string sJsonToReturn = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return sJsonToReturn;
        }
        public void Patients_Add(modPatients modPatients)
        {
            DALEF.EFPatients oP = new EFPatients();
            string pNom = modPatients.NomPatient;
            string pPrenom = modPatients.PrenomPatient;
            DateTime pdateDeNaissance = modPatients.Date_De_Naissance;
            oP.Patients_Add(pNom, pPrenom, pdateDeNaissance);
        }
        public void RDV_Add(modRDV modRDV)
        {
            DALEF.EFPatients o = new EFPatients();

            int PatientID = modRDV.Patient_ID;
            int RecapID = modRDV.Recap_ID;
            DateTime Date = modRDV.Date;
            TimeSpan HeureDebut = modRDV.Heure_Debut;
            TimeSpan HeureFin = modRDV.Heure_Fin;
            int LocalID = modRDV.Local_ID;
            string Identifiant = modRDV.Identifiant_RDV;


            o.AddRDV(PatientID, RecapID, Date, HeureDebut, HeureFin, LocalID, Identifiant); 
        }

        public bool DeleteRDVByIdentifiant(string pIdentifiant)
        {
            DALEF.EFPatients o = new EFPatients();
            return o.DeleteRDVByIdentifiant(pIdentifiant);
        }
    }
}
