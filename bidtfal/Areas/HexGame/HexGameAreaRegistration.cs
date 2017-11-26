using System.Web.Mvc;

namespace bidtfal.Areas.HexGame
{
    public class HexGameAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HexGame";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HexGame_default",
                "HexGame/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "bidtfal.Areas.HexGame.Controllers" }
            );
        }
    }
}