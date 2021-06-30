using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Modeles;
using RouteAttribute = System.Web.Http.RouteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace WebApiMedicalendrier.Controllers
{
    public class PatientsController : Controller
    {
        // GET: Patients

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Patients/GetPatients")]
        public List<Modeles.modPatients> GetPatients()
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            List<Modeles.modPatients> lst = new List<modPatients>();
            string Json = o.Patients_All(); 
            lst = JsonConvert.DeserializeObject<List<Modeles.modPatients>>(Json);
            return lst;
        }
        [HttpPost]
        [Route("api/Patients/AddPatients")]
        public void AddPatients([FromBody]modPatients modPatients)
        {
            BusinessLayer.blPatients o = new BusinessLayer.blPatients();
            o.Patients_Add(modPatients);
            //lst = JsonConvert.DeserializeObject<List<Modeles.modPatients>>(Json);
            //return lst;
        }
    }
}