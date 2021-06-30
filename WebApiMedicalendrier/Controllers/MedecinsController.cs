using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using BusinessLayer;
using CustomError;

namespace WebApiMedicalendrier.Controllers
{
    public class MedecinsController : Controller
    {
        // GET: Medecins
        [System.Web.Http.Route("api/Medecins/GetMedecins")]
        public List<Modeles.modMedecins> GetMedecins()
        {
            BusinessLayer.blMedecins o = new BusinessLayer.blMedecins();
            List<Modeles.modMedecins> lst = new List<Modeles.modMedecins>();
            string Json = o.Medecins_All();
            lst = JsonConvert.DeserializeObject<List<Modeles.modMedecins>>(Json);

            //throw new MyCustomError(20); 

            return lst;


        }
    }
}