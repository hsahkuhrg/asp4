using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace ASP10.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        public ActionResult About()
        {
            IEnumerable<DataWork.Models.Respons> respons = DataWork.WorkWithContext.GetRespons();
            return View("YourArticle", respons);
        }
        [HttpPost]
        public ActionResult About(DataWork.Models.Respons respons1)
        {
            respons1.Date = System.DateTime.Today;
            DataWork.WorkWithContext.SendRespons(respons1);

            IEnumerable<DataWork.Models.Respons> respons = DataWork.WorkWithContext.GetRespons();
            return View("YourArticle", respons);
        }
    }
}