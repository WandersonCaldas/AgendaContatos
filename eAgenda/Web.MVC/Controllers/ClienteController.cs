using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.MVC.Models;
using Web.MVC.ViewModel;

namespace Web.MVC.Controllers
{
    public class ClienteController : BaseController
    {
        private DataContext db = new DataContext();

        // GET: Cliente
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]        
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.txt_telefone = model.txt_telefone.Replace("-", "").Replace("(", "").Replace(")", "").Trim();
                if (model.txt_telefone2 != null)
                {
                    model.txt_telefone2 = model.txt_telefone2.Replace("-", "").Replace("(", "").Replace(")", "").Trim();
                }

                try
                {
                    model.cod_estado = Convert.ToInt32(Request["cod_estado"]);

                    if (model.cod_estado == 0)
                    {
                        ModelState.AddModelError(string.Empty, "O campo Estado é obrigatório.");
                        return View(model);
                    }
                }
                catch (Exception ex)
                {

                }

                try
                {
                    model.cod_cidade = Convert.ToInt32(Request["cod_cidade"]);

                    if (model.cod_cidade == 0)
                    {
                        ModelState.AddModelError(string.Empty, "O campo Cidade é obrigatório.");
                        return View(model);
                    }
                }
                catch (Exception ex)
                {

                }

                db.Clientes.Add(Mapper.Map<Cliente>(model));
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel model = Mapper.Map<ClienteViewModel>(db.Clientes.Find(id));
            if (model == null)
            {
                return HttpNotFound();
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel model)
        {
            try
            {
                model.cod_estado = Convert.ToInt32(Request["cod_estado"]);

                if (model.cod_estado == 0)
                {
                    ModelState.AddModelError(string.Empty, "O campo Estado é obrigatório.");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                model.cod_cidade = Convert.ToInt32(Request["cod_cidade"]);

                if (model.cod_cidade == 0)
                {
                    ModelState.AddModelError(string.Empty, "O campo Cidade é obrigatório.");
                    return View(model);
                }
            } catch(Exception ex)
            {
                
            }                                    

            if (ModelState.IsValid)
            {
                model.txt_telefone = model.txt_telefone.Replace("-", "").Replace("(", "").Replace(")", "").Trim();
                if (model.txt_telefone2 != null)
                {
                    model.txt_telefone2 = model.txt_telefone2.Replace("-", "").Replace("(", "").Replace(")", "").Trim();
                }                

                db.Entry(Mapper.Map<Cliente>(model)).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}