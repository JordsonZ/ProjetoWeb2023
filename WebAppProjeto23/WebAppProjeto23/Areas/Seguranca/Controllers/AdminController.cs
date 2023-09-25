using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto23.Infraestrutura;

namespace WebAppProjeto23.Areas.Seguranca.Controllers
{
    public class AdminController : Controller
    {
        // GET: Seguranca/Admin
            // Definição da Propriedade GerenciadorUsuario
            private GerenciadorUsuario GerenciadorUsuario
        {
            get
            {
                return HttpContext.GetOwinContext().
                GetUserManager<GerenciadorUsuario>();

            }
        }
        // GET: Seguranca/Admin
            public ActionResult Index()
            {
            return View(GerenciadorUsuario.Users);
            }
    }
}