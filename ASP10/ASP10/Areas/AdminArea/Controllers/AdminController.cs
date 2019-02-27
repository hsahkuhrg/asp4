using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;

namespace ASP10.Areas.AdminArea.Controllers
{
    [Authorize(Roles = "admin, user")]
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult AdminPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminPage(string Name, string Text, int[] Id)
        {
            
            DataWork.Models.Article article = new DataWork.Models.Article() { Name = Name, Text = Text };
            DataWork.WorkWithContext.AddArticle(article, Id);
            return View();
        }
    }
}