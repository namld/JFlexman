using System.Web.Mvc;

namespace JFlexman.Areas.JFlexman
{
    public class JFlexmanAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "JFlexman";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "JFlexman_default",
                "JFlexman/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
