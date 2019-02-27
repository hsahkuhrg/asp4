using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP10.Controllers
{
    public class HomeController : Controller
    {
        static Models.Vote vote;
        public ActionResult Index()
        {
            IEnumerable<DataWork.Models.Article> articles = DataWork.WorkWithContext.GetSpliteArticles();
            
            ViewBag.Vote = vote;
            return View(articles);
        }

        public ActionResult More(int Id)
        {
            DataWork.Models.Article article = DataWork.WorkWithContext.GetArticle(Id); 
            return View(article);
        }

        [HttpPost]
        public ActionResult Vote(int RadioChose)
        {
            vote.Popular[RadioChose]++;
            return RedirectToAction("Index");
        }

        static HomeController()
        {
            vote = new Models.Vote();
            vote.Popular = new int[vote.Article.Count];
            for (int i = 0; i < vote.Popular.Length; i++)
            {
                vote.Popular[i] = 0;
            }
        }
    }
}