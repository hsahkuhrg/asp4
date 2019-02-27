using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP10.Controllers
{
    public class ManDatailsController : Controller
    {
        public ActionResult Contact(string name, string answer1 = "null", string answer2 = "null", string answer3 = "null", string answer4 = "null")
        {
            if (HttpContext.Request.HttpMethod.ToString() == "GET")
            {
                return View("FormChose");
            }
            DataWork.WorkWithContext.SendForm(new DataWork.Models.Form() { Name = name, Answer1 = answer1, Answer2 = answer2, Answer3 = answer3, Answer4 = answer4 });
            IEnumerable<DataWork.Models.Form> forms = DataWork.WorkWithContext.GetForm();
            return View("ShowForm", forms);
        }
    }
}