using System.Web.Mvc;

namespace WebAppProjeto2023.Areas.Tabelas
{
    public class TabelasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Tabelas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Tabelas_default",
                "Tabelas/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}