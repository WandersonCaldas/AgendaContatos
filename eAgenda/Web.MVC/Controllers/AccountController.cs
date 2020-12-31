using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.MVC.Models;
using Web.MVC.ViewModel;

namespace Web.MVC.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
           
            Usuario usuario = new Usuario();
            usuario = db.Usuarios.ToList().Where(x => x.txt_login == model.txt_login.Trim() && x.txt_senha == model.txt_senha.Trim()).FirstOrDefault();

            if (usuario != null)
            {                

                if (usuario.st_ativo == false)
                {
                    ModelState.AddModelError(string.Empty, "USUÁRIO INATIVO");
                    return View(model);
                }

                Session["cod_usuario"] = usuario.cod_usuario;
                Session["txt_login"] = model.txt_login.Trim();
            } else
            {
                ModelState.AddModelError(string.Empty, "USUÁRIO NÃO ENCONTRADO");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}