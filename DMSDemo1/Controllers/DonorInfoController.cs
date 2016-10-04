using DMSDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMSDemo1.Controllers
{
    public class DonorInfoController : Controller
    {
        private readonly List <DonorInfo>donors = new List<DonorInfo>()
    {
        new DonorInfo { Id = 1, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com" },
        new DonorInfo { Id = 2, Name = "Juan Torres", Email = "jtorres@hotmail.com" },
        new DonorInfo { Id = 3, Name = "Oscar Camacho", Email = "oscar@hotmail.com" },
        new DonorInfo { Id = 4, Name = "Gina Urrego", Email = "ginna@hotmail.com" },
        new DonorInfo { Id = 5, Name = "Nathalia Ramirez", Email = "natha@hotmail.com" },
        new DonorInfo { Id = 6, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com" },
        new DonorInfo { Id = 7, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com" }
    };

        public ActionResult Index()
        {
            return View(donors);
        }
    }
}