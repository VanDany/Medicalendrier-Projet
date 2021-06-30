using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BusinessLayer;
using Modeles;
using Newtonsoft.Json;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using RouteAttribute = System.Web.Mvc.RouteAttribute;

namespace WebApiMed.Controllers
{
    public class MedecinsController : ApiController
    {

        [HttpGet]
        [Route("api/Medecins/GetMedByName")]
        public int? GetMedByName(string pNom, string pPrenom)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            var id = o.Medecins_ByName(pNom, pPrenom);
            return id;

        }

        [HttpGet]
        [Route("api/Medecins/GetMedByID")]
        public modMedecins GetMedByID(int pMedecinID)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            Modeles.modMedecins lst = new Modeles.modMedecins();
            string json = o.Medecins_byID(pMedecinID);
            lst = JsonConvert.DeserializeObject<Modeles.modMedecins>(json);
            return lst;

        }
        //GET: MaisonsMed
        [Route("api/Medecins/GetMaisonsMed")]
        [HttpGet]
        public List<Modeles.modMaisonsMed> GetMaisonsMed()
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<Modeles.modMaisonsMed> lst = new List<Modeles.modMaisonsMed>();
            string Json = o.MaisonsMed_All();
            lst = JsonConvert.DeserializeObject<List<Modeles.modMaisonsMed>>(Json);
            return lst;
        }
        //GET: Specialites
        [Route("api/Medecins/GetSpecialites")]
        [HttpGet]
        public List<Modeles.modSpecialites> GetSpecialites()
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<Modeles.modSpecialites> lst = new List<Modeles.modSpecialites>();
            string Json = o.Specialites_All();
            lst = JsonConvert.DeserializeObject<List<Modeles.modSpecialites>>(Json);
            return lst;
        }

        [Route("api/Medecins/GetDispo")]
        [HttpGet]
        public List<Modeles.modDispo> GetDispo(int pSpecialiteID, int pMaisonMedID, string pDate)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modDispo> lst = new List<Modeles.modDispo>();
            string Json = o.GetDispo(pSpecialiteID, pMaisonMedID, pDate);
            lst = JsonConvert.DeserializeObject<List<Modeles.modDispo>>(Json);
            return lst;
        }

        [Route("api/Medecins/GetPlanning")]
        [HttpGet]
        public List<Modeles.modPlanningMed> GetPlanning(int pMedecinID, string pDate)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modPlanningMed> lst = new List<Modeles.modPlanningMed>();
            string Json = o.GetPlanning(pMedecinID, pDate);
            lst = JsonConvert.DeserializeObject<List<Modeles.modPlanningMed>>(Json);
            return lst;
        }

        [Route("api/Medecins/GetAllPresences")]
        [HttpGet]
        public List<Modeles.modPresencesMed> GetAllPresences(int pMedecinID, string pDate)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modPresencesMed> lst = new List<Modeles.modPresencesMed>();
            string Json = o.GetAllPresences(pMedecinID, pDate);
            lst = JsonConvert.DeserializeObject<List<Modeles.modPresencesMed>>(Json);
            return lst;
        }

        [Route("api/Medecins/GetRDVaCOnfirmer")]
        [HttpGet]
        public List<Modeles.modPlanningMed> GetRDVaConfirmer(int pMedecinID)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modPlanningMed> lst = new List<Modeles.modPlanningMed>();
            string Json = o.GetRDVaConfirmer(pMedecinID);
            lst = JsonConvert.DeserializeObject<List<Modeles.modPlanningMed>>(Json);
            return lst;
        }
        [Route("api/Medecins/GetMMSByMedID")]
        [HttpGet]
        public List<Modeles.modMMS> GetMMSbyMedID(int pMedecinID)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modMMS> lst = new List<Modeles.modMMS>();
            string Json = o.GetMMSByMedID(pMedecinID);
            lst = JsonConvert.DeserializeObject<List<Modeles.modMMS>>(Json);
            return lst;
        }

        


        [Route("api/Medecins/GetHorairesPris")]
        [HttpGet]
        public List<modHorairesPris> GetHorairesPris(int pRecapID, string pDate)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modHorairesPris> lst = new List<Modeles.modHorairesPris>();
            string Json = o.GetHorairesPris(pRecapID, pDate);
            lst = JsonConvert.DeserializeObject<List<Modeles.modHorairesPris>>(Json);
            return lst;
        }
        [HttpPost]
        [Route("api/Medecins/AddPresences")]
        public void AddPresences([FromBody] List<modPresencesMed> modPresences)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            o.PresencesMed_Add(modPresences);
        }
        [HttpPost]
        [Route("api/Medecins/AddMMS")]
        public void AddMMS([FromBody] modMMS modMMS)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            o.AssociationMMS_Add(modMMS);
        }
        [HttpPost]
        [Route("api/Medecins/AddLien")]
        public void AddLien([FromBody] modLienActif mod)
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            o.AddLien(mod);
        }

        [HttpPut]
        [Route("api/Medecins/AddConfirmation")]
        public bool AddConfirmation([FromBody]string pIdentifiant)
        {
            BusinessLayer.blMedecins o = new blMedecins();
            bool done = o.AddConfirmation(pIdentifiant);
            return done;
        }

    }
}