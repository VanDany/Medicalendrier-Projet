using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeles;

namespace DALEF
{
    public class EFPatients
    {
        public List<SelectAllPatients_Result> SelectAll()
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            List<SelectAllPatients_Result> lstPatients = cx.SelectAllPatients().ToList();
            return lstPatients;
        }

        public void Patients_Add(string pNom, string pPrenom, DateTime pdateDeNaissance)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            cx.AddPatient(pNom, pPrenom, pdateDeNaissance);
        }

        public void AddRDV(int PatientID, int RecapID, DateTime Date, TimeSpan HeureDebut, TimeSpan HeureFin,
            int LocalID, string Identifiant)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            cx.AddRDV(PatientID, RecapID, Date, HeureDebut, HeureFin, LocalID, Identifiant);
        }
        public List<SelectAllMaisonMed_Result> SelectAllMaisonsMed()
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            List<SelectAllMaisonMed_Result> lstMaisonsMed = cx.SelectAllMaisonMed().ToList();
            return lstMaisonsMed;
        }
        public SelectPresencesByMed_Result GetPresences(int pMedecinID, int pMaisonMedID, string pDate)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            DateTime dateOK = Convert.ToDateTime(pDate);
            SelectPresencesByMed_Result lstPresence = cx.SelectPresencesByMed(pMedecinID, pMaisonMedID, dateOK).FirstOrDefault();
            return lstPresence;
        }

        public List<SelectRDVforLocaux_Result> GetRDVforLocaux(int pMedecinID, string pDate)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            DateTime dateOK = Convert.ToDateTime(pDate);
            List<SelectRDVforLocaux_Result> lstRDV = cx.SelectRDVforLocaux(pMedecinID, dateOK).ToList();
            return lstRDV;
        }
        public List<SelectRDVByPatientID_Result> GetRDVByPatientID(int pPatientID, string pDate)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            DateTime dateOK = Convert.ToDateTime(pDate);
            List<SelectRDVByPatientID_Result> lstRDV = cx.SelectRDVByPatientID(pPatientID, dateOK).ToList();
            return lstRDV;
        }

        public List<SelectRDVByIdentifiant_Result> GetRDVByIdentifiant(string pIdentifiant)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            List<SelectRDVByIdentifiant_Result> lstRDV = cx.SelectRDVByIdentifiant(pIdentifiant).ToList();
            return lstRDV;
        }

        public bool DeleteRDVByIdentifiant(string pIdentifiant)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            int done = cx.DeleteRDVByIdentifiant(pIdentifiant);
            if (done == -1)
            {
                return true;
            }
            else return false;
        }
        public List<SelectAllLocaux_Result> SelectAllLocaux(int MaisonMedID)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            List<SelectAllLocaux_Result> lstLocaux = cx.SelectAllLocaux(MaisonMedID).ToList();
            return lstLocaux;
        }
        public List<SelectAllSpecialites_Result> SelectAllSpecialites()
        {
            RDVMedicalEntities cx = new RDVMedicalEntities();
            List<SelectAllSpecialites_Result> lstSpecialites = cx.SelectAllSpecialites().ToList();
            return lstSpecialites;
        }
        public List<GetPatientByInfos_Result> GetPatientByInfos(string pNom, string pPrenom, string pDate)
        {
            RDVMedicalEntities_Patients cx = new RDVMedicalEntities_Patients();
            List<GetPatientByInfos_Result> lst = new List<GetPatientByInfos_Result>();
            DateTime dateOK = Convert.ToDateTime(pDate);
            lst = cx.GetPatientByInfos(pNom, pPrenom, dateOK).ToList();
            return lst;
        }

    }
}
