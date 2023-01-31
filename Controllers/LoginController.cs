using GerenciarGrupoCorujao.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarGrupoCorujao.Controllers {
    public class LoginController : Controller {
        public IActionResult Index() {
            UserViewModel user = new UserViewModel();
            user.Email = "";
            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Teste(UserViewModel user)
           {
            
            user.Email = "email enviado";
            return View("Index", user);
        }
    }
}
