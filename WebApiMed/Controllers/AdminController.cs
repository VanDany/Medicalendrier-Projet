using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Modeles;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApiMed.Controllers
{
    public class AdminController : ApiController
    {
        [HttpPost]
        [Route("api/Admin/AddMaisonMed")]
        public void AddMaisonMed([FromBody] modMaisonsMed modPatients)
        {
            BusinessLayer.blAdmin o = new BusinessLayer.blAdmin();
            o.MaisonMed_Add(modPatients);
        }
        [HttpPost]
        [Route("api/Admin/AddLocal")]
        public void Local_Add([FromBody] modLocaux modLocaux)
        {
            BusinessLayer.blAdmin o = new BusinessLayer.blAdmin();
            o.Local_Add(modLocaux);
        }
        
    }
}