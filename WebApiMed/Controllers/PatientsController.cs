using Modeles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Mvc.RouteAttribute;

namespace WebApiMed.Controllers
{
    public class PatientsController : ApiController
    {
        // GET: Patients
        [Route("api/Patients/GetPatients")]
        [HttpGet]
        public List<Modeles.modPatients> GetPatients()
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<Modeles.modPatients> lst = new List<Modeles.modPatients>();
            string Json = o.Patients_All();
            lst = JsonConvert.DeserializeObject<List<Modeles.modPatients>>(Json);
            return lst;
        }

        [HttpPost]
        [Route("api/Patients/AddPatients")]
        public void AddPatients([FromBody] modPatients modPatients)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            o.Patients_Add(modPatients);
        }

        [HttpPost]
        [Route("api/Patients/AddRDV")]
        public void AddRDV([FromBody] modRDV modRDV)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            o.RDV_Add(modRDV);
        }

        [Route("api/Patients/GetPresences")]
        [HttpGet]
        public modPresencesMed GetPresences(int pMedecinID, int pMaisonMedID, string pDate)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            modPresencesMed lst = new modPresencesMed();
            string Json = o.GetPresences(pMedecinID, pMaisonMedID, pDate);
            lst = JsonConvert.DeserializeObject<modPresencesMed>(Json);
            return lst;
        }
        [Route("api/Patients/GetPatientByInfos")]
        [HttpGet]
        public List<modPatients> GetPatientByInfos(string pNom, string pPrenom, string pDate)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<modPatients> lst = new List<modPatients>();
            string Json = o.GetPatientByInfos(pNom, pPrenom, pDate);
            lst = JsonConvert.DeserializeObject<List<modPatients>>(Json);
            return lst;
        }

        [Route("api/Patients/GetRDVbyPatientID")]
        [HttpGet]
        public List<modPlanningMed> GetRDVbyPatientID(int pPatientID, string pDate)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<modPlanningMed> lst = new List<modPlanningMed>();
            string Json = o.GetRDVByPatientID(pPatientID, pDate);
            lst = JsonConvert.DeserializeObject<List<modPlanningMed>>(Json);
            return lst;
        }
        [Route("api/Patients/GetRDVbyPatientID")]
        [HttpGet]
        public List<modGestionRDV> GetRDVbyIdentifiant(string pIdentifiant)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<modGestionRDV> lst = new List<modGestionRDV>();
            string Json = o.GetRDVByIdentifiant(pIdentifiant);
            lst = JsonConvert.DeserializeObject<List<modGestionRDV>>(Json);
            return lst;
        }
        [Route("api/Patients/DeleteRDVByIdentifiant")]
        [HttpDelete]
        public bool DeleteRDVByIdentifiant(string pIdentifiant)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            bool done = o.DeleteRDVByIdentifiant(pIdentifiant);
            return done;
        }

        [Route("api/Patients/SelectAllLocaux")]
        [HttpGet]
        public List<Modeles.modLocaux> SelectAllLocaux(int MaisonMedID)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<Modeles.modLocaux> lst = new List<Modeles.modLocaux>();
            string Json = o.SelectAllLocaux(MaisonMedID);
            lst = JsonConvert.DeserializeObject<List<Modeles.modLocaux>>(Json);
            return lst;
            
            
        }
        public List<modPlanningMed> GetPlanningForLocaux(int pMaisonMedID, string pDate)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<modPlanningMed> lst = new List<modPlanningMed>();
            string Json = o.GetPlanningForLocaux(pMaisonMedID, pDate);
            lst = JsonConvert.DeserializeObject<List<modPlanningMed>>(Json);
            return lst;
        }

        [HttpGet]
        [Route("api/Patients/Recap")]
        public void GetRecap()
        {

        }
    }
}