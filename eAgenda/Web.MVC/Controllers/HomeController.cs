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
    public class HomeController : BaseController
    {
        private DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<ClienteViewModel>>(db.Clientes.ToList()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string txt_pesquisa)
        {            
            if (!string.IsNullOrWhiteSpace(txt_pesquisa) && txt_pesquisa != null)
            {
                return View(Mapper.Map<IEnumerable<ClienteViewModel>>(db.Clientes.Where(x => x.txt_cliente.Trim().ToUpper().Contains(txt_pesquisa.Trim().ToUpper())).ToList()));
            } else
            {
                return View(Mapper.Map<IEnumerable<ClienteViewModel>>(db.Clientes.ToList()));
            }            
        }
    }
}