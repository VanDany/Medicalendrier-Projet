using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEF;
using Modeles;
using Newtonsoft.Json;

namespace BusinessLayer
{
    public class blMedecins
    {
        public string GetDispo(int pSpecialiteID, int pMaisonMedID, string pDateID)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<DALEF.SelectAllDispo_Result> lst = cx.SelectDispo(pSpecialiteID, pMaisonMedID, pDateID);

            List<Modeles.modDispo> lstDispo = new List<modDispo>();
            foreach (DALEF.SelectAllDispo_Result o in lst)
            {
                Modeles.modDispo oDispo = new modDispo();
                oDispo.Recap_ID = o.Recap_ID;
                oDispo.Medecin_ID = o.Medecin_ID;
                oDispo.Duree_Consultation = o.Duree_Consultation;

                lstDispo.Add(oDispo);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstDispo, Formatting.Indented);
            return sJsonToReturn;

        }
        public string GetAllPresences(int pMedecinID, string pDate)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<DALEF.SelectAllPresencesByMed_Result> lst = cx.SelectAllPresencesByMed(pMedecinID, pDate);

            List<Modeles.modPresencesMed> lstPresences = new List<modPresencesMed>();
            foreach (DALEF.SelectAllPresencesByMed_Result o in lst)
            {
                Modeles.modPresencesMed oPresences = new modPresencesMed();
                oPresences.Presence_ID = o.Presence_ID;
                oPresences.Medecin_ID = o.Medecin_ID;
                oPresences.Maison_Med_ID = o.Maison_Med_ID;
                oPresences.DatePresence = o.DatePresence;
                oPresences.Heure_Debut = o.Heure_Debut;
                oPresences.Heure_Fin = o.Heure_Fin;

                lstPresences.Add(oPresences);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstPresences, Formatting.Indented);
            return sJsonToReturn;
        }


        public string GetPlanning(int pMedecinID, string pDate)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<DALEF.SelectPlanningByDate_Result> lst = cx.SelectPlanning(pMedecinID, pDate);

            List<Modeles.modPlanningMed> lstPlanning = new List<modPlanningMed>();
            foreach (DALEF.SelectPlanningByDate_Result o in lst)
            {
                Modeles.modPlanningMed oPlanning = new modPlanningMed();
                oPlanning.NomPatient = o.NomPatient;
                oPlanning.PrenomPatient = o.PrenomPatient;
                oPlanning.NomMaisonMed = o.NomMaisonMed;
                oPlanning.Adresse = o.Adresse;
                oPlanning.Nom_Specialite = o.Nom_Specialite;
                oPlanning.Heure_Debut = o.Heure_Debut;
                oPlanning.Heure_Fin = o.Heure_Fin;
                oPlanning.NomLocal = o.NomLocal;
                oPlanning.Confirmation = o.Confirmation;
                oPlanning.Identifiant_RDV = o.Identifiant_RDV;

                lstPlanning.Add(oPlanning);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstPlanning, Formatting.Indented);
            return sJsonToReturn;
        }
        public string GetRDVaConfirmer(int pMedecinID)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<DALEF.SelectRDVaConfirmer_Result> lst = cx.SelectRDVaConfirmer(pMedecinID);

            List<Modeles.modPlanningMed> lstPlanning = new List<modPlanningMed>();
            foreach (DALEF.SelectRDVaConfirmer_Result o in lst)
            {
                Modeles.modPlanningMed oPlanning = new modPlanningMed();
                oPlanning.RDV_ID = o.RDV_ID;
                oPlanning.NomPatient = o.NomPatient;
                oPlanning.PrenomPatient = o.PrenomPatient;
                oPlanning.NomMaisonMed = o.NomMaisonMed;
                oPlanning.Adresse = o.Adresse;
                oPlanning.Nom_Specialite = o.Nom_Specialite;
                oPlanning.Heure_Debut = o.Heure_Debut;
                oPlanning.Heure_Fin = o.Heure_Fin;
                oPlanning.NomLocal = o.NomLocal;
                oPlanning.Confirmation = o.Confirmation;
                oPlanning.Identifiant_RDV = o.Identifiant_RDV;
                lstPlanning.Add(oPlanning);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstPlanning, Formatting.Indented);
            return sJsonToReturn;
        }
        public string GetMMSByMedID(int pMedecinID)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<DALEF.SelectMMSByMedID_Result> lst = cx.SelectMMSByMedID(pMedecinID);

            List<Modeles.modMMS> lstMMS = new List<modMMS>();
            foreach (DALEF.SelectMMSByMedID_Result o in lst)
            {
                Modeles.modMMS oMMS = new modMMS();
                oMMS.Recap_ID = o.Recap_ID;
                oMMS.Medecin_ID = o.Medecin_ID;
                oMMS.Maison_Med_ID = o.MaisonMed_ID;
                oMMS.Duree_Consultation = o.Duree_Consultation;
                oMMS.Specialite_ID = o.Specialite_ID;
                oMMS.Verif_Lien = o.Verifcation_Lien;
                lstMMS.Add(oMMS);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstMMS, Formatting.Indented);
            return sJsonToReturn;
        }
        

        public string GetHorairesPris(int pRecapID, string pDate)
        {
            DALEF.EFMedecins cx = new EFMedecins();
            List<TimeSpan?> lst = cx.SelectDisponibiliteForRDV(pRecapID, pDate);

            List<Modeles.modHorairesPris> lstRDV = new List<modHorairesPris>();
            foreach (TimeSpan? o in lst)
            {
                Modeles.modHorairesPris oDispo = new modHorairesPris();
                oDispo.Heure_Debut = o.Value;
                lstRDV.Add(oDispo);
            }
            string sJsonToReturn = JsonConvert.SerializeObject(lstRDV, Formatting.Indented);
            return sJsonToReturn;

        }
        public int? Medecins_ByName(string pNom, string pPrenom)
        {
            DALEF.EFMedecins o = new EFMedecins();
            var x = o.SelectMedByName(pNom, pPrenom);
            return x;
        }

        public string Medecins_byID(int ID)
        {
            DALEF.EFMedecins o = new EFMedecins();
            var lst = o.SelectMedByID(ID);
            modMedecins lstMedecins = new modMedecins();
            lstMedecins.Nom = lst.Nom;
            lstMedecins.Prenom = lst.Prenom;
            string sJsonToReturn = JsonConvert.SerializeObject(lstMedecins, Formatting.Indented);
            return sJsonToReturn;
        }
        public void PresencesMed_Add(List<modPresencesMed> modPresencesMed)
        {
            DALEF.EFMedecins o = new EFMedecins();
            for (int i = 0; i < modPresencesMed.Count; i++)
            {
                int pMaisonMedId = modPresencesMed[i].Maison_Med_ID;
                int pMedecinId = modPresencesMed[i].Medecin_ID;
                DateTime pDatePresence = modPresencesMed[i].DatePresence;
                TimeSpan pHeureDebut = modPresencesMed[i].Heure_Debut;
                TimeSpan pHeureFin = modPresencesMed[i].Heure_Fin;
                o.PresencesMed_Add(pMaisonMedId, pMedecinId, pDatePresence, pHeureDebut, pHeureFin);
            }
        }

        public void AssociationMMS_Add(modMMS modMMS)
        {
            DALEF.EFMedecins o = new EFMedecins();

                int pMedecin_ID = modMMS.Medecin_ID;
                int pSpecialite_ID = modMMS.Specialite_ID;
                int pMaison_Med_ID = modMMS.Maison_Med_ID;
                int pDureeConsult = modMMS.Duree_Consultation;
                bool pVerif_Lien = modMMS.Verif_Lien;

                o.AssociationMMS(pMedecin_ID, pSpecialite_ID, pMaison_Med_ID, pDureeConsult, pVerif_Lien);
        }

        public void AddLien(modLienActif mod)
        {
            DALEF.EFMedecins o = new EFMedecins();
            o.AddLien(mod);
        }
        public bool AddConfirmation(string pIdentifiant)
        {
            DALEF.EFMedecins o = new EFMedecins();
            return o.AddConfirmation(pIdentifiant);
        }
    }
}
