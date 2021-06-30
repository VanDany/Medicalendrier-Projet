using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Modeles;
namespace DALEF
{
    public class EFMedecins
    {
        public int? SelectMedByName(string pNom, string pPrenom)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            
            var test = cx.SelectMedByName(pNom,pPrenom).FirstOrDefault();
            return test;
        }
        public SelectMedByID_Result SelectMedByID(int? pID)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();

            var test = cx.SelectMedByID(pID).FirstOrDefault();
            return test;
        }
        public List<SelectAllDispo_Result>SelectDispo(int pSpecialitesID, int pMaisonMedID, string pDate)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            DateTime dateOK = Convert.ToDateTime(pDate);
            var ok = cx.SelectAllDispo(pSpecialitesID, pMaisonMedID, dateOK).ToList();
            return ok;
        }
        public List<SelectMMSByMedID_Result> SelectMMSByMedID(int pMedecinID)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            var ok = cx.SelectMMSByMedID(pMedecinID).ToList();
            return ok;
        }
        
        public List<SelectAllPresencesByMed_Result> SelectAllPresencesByMed(int pMedecinID, string pDate)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            DateTime dateOK = Convert.ToDateTime(pDate);
            var ok = cx.SelectAllPresencesByMed(pMedecinID,dateOK).ToList();
            return ok;
        }

        public List<SelectPlanningByDate_Result> SelectPlanning(int pMedecinID, string pDate)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            DateTime dateOK = Convert.ToDateTime(pDate);
            var ok = cx.SelectPlanningByDate(pMedecinID, dateOK).ToList();
            return ok;
        }

        public List<SelectRDVaConfirmer_Result> SelectRDVaConfirmer(int pMedecinID)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            var ok = cx.SelectRDVaConfirmer(pMedecinID).ToList();
            return ok;
        }

        public List<TimeSpan?> SelectDisponibiliteForRDV(int pRecapID, string pDate)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            DateTime dateOK = Convert.ToDateTime(pDate);
            var ok = cx.SelectRDVforDisponibility(pRecapID, dateOK).ToList();
            return ok;
        }

        public void PresencesMed_Add(int pMaisonMedId, int pMedecinId, DateTime pDatePresence, TimeSpan pHeureDebut, TimeSpan pHeureFin)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            cx.AddPresences( pMedecinId, pMaisonMedId, pDatePresence, pHeureDebut, pHeureFin);
        }

        public void AssociationMMS(int pMedecin_ID, int pSpecialite_ID, int pMaison_Med_ID, int pDureeConsult, bool pVerif_Lien)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            cx.AddAssociation(pMedecin_ID, pMaison_Med_ID, pSpecialite_ID, pDureeConsult, pVerif_Lien);
        }

        public void AddLien(modLienActif mod)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            cx.AddLienActif(mod.LienActif, mod.RecapID);
        }

        public bool AddConfirmation(string pIdentifiant)
        {
            RDVMedicalEntities_Medecins cx = new RDVMedicalEntities_Medecins();
            int ok =  cx.AddConfirmation(pIdentifiant);
            if (ok == 1)
                return true;
            else return false;
        }
    }
}
