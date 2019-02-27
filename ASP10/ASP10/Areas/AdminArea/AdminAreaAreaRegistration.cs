using System.Web.Mvc;

namespace ASP10.Areas.AdminArea
{
    public class AdminAreaAreaRegistration : AreaRegistration 
    {
        /*public override string AreaName 
        {
            get 
            {
                return "AdminArea";
            }
        }*/
        public override string AreaName => "AdminArea";
        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminArea_default",
                "AdminArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}