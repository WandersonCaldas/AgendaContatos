using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.MVC.Models;
using Web.MVC.ViewModel;

namespace Web.MVC.Controllers
{
    public class PaisController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Pais
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<PaisViewModel>>(db.Paises.ToList()));
        }

        // GET: Pais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaisViewModel paisViewModel = Mapper.Map<PaisViewModel>(db.Paises.Find(id));
            if (paisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(paisViewModel);
        }

        // GET: Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "txt_pais")] PaisViewModel paisViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Paises.Add(Mapper.Map<Pais>(paisViewModel));
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paisViewModel);
        }

        // GET: Pais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaisViewModel paisViewModel = Mapper.Map<PaisViewModel>(db.Paises.Find(id));
            if (paisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(paisViewModel);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_pais,txt_pais")] PaisViewModel paisViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Mapper.Map<Pais>(paisViewModel)).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paisViewModel);
        }

        // GET: Pais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaisViewModel paisViewModel = Mapper.Map<PaisViewModel>(db.Paises.Find(id));
            if (paisViewModel == null)
            {
                return HttpNotFound();
            }
            return View(paisViewModel);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {            
            db.Paises.Remove(db.Paises.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
