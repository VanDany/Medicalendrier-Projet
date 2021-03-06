//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RDVMedicalEntities_Medecins : DbContext
    {
        public RDVMedicalEntities_Medecins()
            : base("name=RDVMedicalEntities_Medecins")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int AddAssociation(Nullable<int> medecin_ID, Nullable<int> maison_Med_ID, Nullable<int> specialite_ID, Nullable<int> dureeConsult, Nullable<bool> verif)
        {
            var medecin_IDParameter = medecin_ID.HasValue ?
                new ObjectParameter("Medecin_ID", medecin_ID) :
                new ObjectParameter("Medecin_ID", typeof(int));
    
            var maison_Med_IDParameter = maison_Med_ID.HasValue ?
                new ObjectParameter("Maison_Med_ID", maison_Med_ID) :
                new ObjectParameter("Maison_Med_ID", typeof(int));
    
            var specialite_IDParameter = specialite_ID.HasValue ?
                new ObjectParameter("Specialite_ID", specialite_ID) :
                new ObjectParameter("Specialite_ID", typeof(int));
    
            var dureeConsultParameter = dureeConsult.HasValue ?
                new ObjectParameter("DureeConsult", dureeConsult) :
                new ObjectParameter("DureeConsult", typeof(int));
    
            var verifParameter = verif.HasValue ?
                new ObjectParameter("Verif", verif) :
                new ObjectParameter("Verif", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAssociation", medecin_IDParameter, maison_Med_IDParameter, specialite_IDParameter, dureeConsultParameter, verifParameter);
        }
    
        public virtual int AddConfirmation(string identifiant)
        {
            var identifiantParameter = identifiant != null ?
                new ObjectParameter("Identifiant", identifiant) :
                new ObjectParameter("Identifiant", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddConfirmation", identifiantParameter);
        }
    
        public virtual int AddLienActif(Nullable<bool> lienActif, Nullable<int> recapID)
        {
            var lienActifParameter = lienActif.HasValue ?
                new ObjectParameter("LienActif", lienActif) :
                new ObjectParameter("LienActif", typeof(bool));
    
            var recapIDParameter = recapID.HasValue ?
                new ObjectParameter("RecapID", recapID) :
                new ObjectParameter("RecapID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddLienActif", lienActifParameter, recapIDParameter);
        }
    
        public virtual int AddPresences(Nullable<int> medecin_ID, Nullable<int> maison_Med_ID, Nullable<System.DateTime> datePresence, Nullable<System.TimeSpan> heure_Debut, Nullable<System.TimeSpan> heure_Fin)
        {
            var medecin_IDParameter = medecin_ID.HasValue ?
                new ObjectParameter("Medecin_ID", medecin_ID) :
                new ObjectParameter("Medecin_ID", typeof(int));
    
            var maison_Med_IDParameter = maison_Med_ID.HasValue ?
                new ObjectParameter("Maison_Med_ID", maison_Med_ID) :
                new ObjectParameter("Maison_Med_ID", typeof(int));
    
            var datePresenceParameter = datePresence.HasValue ?
                new ObjectParameter("DatePresence", datePresence) :
                new ObjectParameter("DatePresence", typeof(System.DateTime));
    
            var heure_DebutParameter = heure_Debut.HasValue ?
                new ObjectParameter("Heure_Debut", heure_Debut) :
                new ObjectParameter("Heure_Debut", typeof(System.TimeSpan));
    
            var heure_FinParameter = heure_Fin.HasValue ?
                new ObjectParameter("Heure_Fin", heure_Fin) :
                new ObjectParameter("Heure_Fin", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPresences", medecin_IDParameter, maison_Med_IDParameter, datePresenceParameter, heure_DebutParameter, heure_FinParameter);
        }
    
        public virtual ObjectResult<SelectAllDispo_Result> SelectAllDispo(Nullable<int> specialiteID, Nullable<int> maisonMedID, Nullable<System.DateTime> date)
        {
            var specialiteIDParameter = specialiteID.HasValue ?
                new ObjectParameter("SpecialiteID", specialiteID) :
                new ObjectParameter("SpecialiteID", typeof(int));
    
            var maisonMedIDParameter = maisonMedID.HasValue ?
                new ObjectParameter("MaisonMedID", maisonMedID) :
                new ObjectParameter("MaisonMedID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllDispo_Result>("SelectAllDispo", specialiteIDParameter, maisonMedIDParameter, dateParameter);
        }
    
        public virtual ObjectResult<SelectAllMedecins_Result> SelectAllMedecins()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllMedecins_Result>("SelectAllMedecins");
        }
    
        public virtual ObjectResult<SelectAllPresencesByMed_Result> SelectAllPresencesByMed(Nullable<int> medecinID, Nullable<System.DateTime> date)
        {
            var medecinIDParameter = medecinID.HasValue ?
                new ObjectParameter("MedecinID", medecinID) :
                new ObjectParameter("MedecinID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllPresencesByMed_Result>("SelectAllPresencesByMed", medecinIDParameter, dateParameter);
        }
    
        public virtual ObjectResult<SelectAllSpecialites_Result> SelectAllSpecialites()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllSpecialites_Result>("SelectAllSpecialites");
        }
    
        public virtual ObjectResult<SelectMedByID_Result> SelectMedByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectMedByID_Result>("SelectMedByID", iDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SelectMedByName(string nom, string prenom)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("Prenom", prenom) :
                new ObjectParameter("Prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SelectMedByName", nomParameter, prenomParameter);
        }
    
        public virtual ObjectResult<SelectMMSByMedID_Result> SelectMMSByMedID(Nullable<int> medecin_ID)
        {
            var medecin_IDParameter = medecin_ID.HasValue ?
                new ObjectParameter("Medecin_ID", medecin_ID) :
                new ObjectParameter("Medecin_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectMMSByMedID_Result>("SelectMMSByMedID", medecin_IDParameter);
        }
    
        public virtual ObjectResult<SelectPlanningByDate_Result> SelectPlanningByDate(Nullable<int> medecinID, Nullable<System.DateTime> date)
        {
            var medecinIDParameter = medecinID.HasValue ?
                new ObjectParameter("MedecinID", medecinID) :
                new ObjectParameter("MedecinID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPlanningByDate_Result>("SelectPlanningByDate", medecinIDParameter, dateParameter);
        }
    
        public virtual ObjectResult<SelectRDVaConfirmer_Result> SelectRDVaConfirmer(Nullable<int> medecin_ID)
        {
            var medecin_IDParameter = medecin_ID.HasValue ?
                new ObjectParameter("Medecin_ID", medecin_ID) :
                new ObjectParameter("Medecin_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectRDVaConfirmer_Result>("SelectRDVaConfirmer", medecin_IDParameter);
        }
    
        public virtual ObjectResult<Nullable<System.TimeSpan>> SelectRDVforDisponibility(Nullable<int> recap_ID, Nullable<System.DateTime> date)
        {
            var recap_IDParameter = recap_ID.HasValue ?
                new ObjectParameter("Recap_ID", recap_ID) :
                new ObjectParameter("Recap_ID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.TimeSpan>>("SelectRDVforDisponibility", recap_IDParameter, dateParameter);
        }
    }
}
