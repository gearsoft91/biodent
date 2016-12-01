using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BioDent.Models;

namespace BioDent.Controllers
{
    public class AOdontologicoesController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: AOdontologicoes
        public ActionResult Index()
        {
            return View(db.AOdontologico.ToList());
        }

        // GET: AOdontologicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AOdontologico aOdontologico = db.AOdontologico.Find(id);
            if (aOdontologico == null)
            {
                return HttpNotFound();
            }
            return View(aOdontologico);
        }

        // GET: AOdontologicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AOdontologicoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,TratamientoPrevio,Extracciones,Profilaxis,Endodoncia,Protesis,Amaigama,Resinas,OrtopediaMaxiliar,Ortodoncia,AlegicoAnestico,FechaUltimaVisitaDentisata")] AOdontologico aOdontologico)
        {
            if (ModelState.IsValid)
            {
                db.AOdontologico.Add(aOdontologico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aOdontologico);
        }

        // GET: AOdontologicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AOdontologico aOdontologico = db.AOdontologico.Find(id);
            if (aOdontologico == null)
            {
                return HttpNotFound();
            }
            return View(aOdontologico);
        }

        // POST: AOdontologicoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,TratamientoPrevio,Extracciones,Profilaxis,Endodoncia,Protesis,Amaigama,Resinas,OrtopediaMaxiliar,Ortodoncia,AlegicoAnestico,FechaUltimaVisitaDentisata")] AOdontologico aOdontologico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aOdontologico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aOdontologico);
        }

        // GET: AOdontologicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AOdontologico aOdontologico = db.AOdontologico.Find(id);
            if (aOdontologico == null)
            {
                return HttpNotFound();
            }
            return View(aOdontologico);
        }

        // POST: AOdontologicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AOdontologico aOdontologico = db.AOdontologico.Find(id);
            db.AOdontologico.Remove(aOdontologico);
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
