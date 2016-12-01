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
    public class ANoPatologicoesController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: ANoPatologicoes
        public ActionResult Index()
        {
            var aNoPatologico = db.ANoPatologico.Include(a => a.Grado1).Include(a => a.Grado2);
            return View(aNoPatologico.ToList());
        }

        // GET: ANoPatologicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANoPatologico aNoPatologico = db.ANoPatologico.Find(id);
            if (aNoPatologico == null)
            {
                return HttpNotFound();
            }
            return View(aNoPatologico);
        }

        // GET: ANoPatologicoes/Create
        public ActionResult Create()
        {
            ViewBag.Alimentacion = new SelectList(db.Grado, "Identificador", "Descripcion");
            ViewBag.Higiene = new SelectList(db.Grado, "Identificador", "Descripcion");
            return View();
        }

        // POST: ANoPatologicoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Higiene,Alimentacion,VecesCepillado,PersonasEnCasa,PracticaDeporte,ConsumeAlcohol,Embarazada,Grado")] ANoPatologico aNoPatologico)
        {
            if (ModelState.IsValid)
            {
                db.ANoPatologico.Add(aNoPatologico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Alimentacion = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Alimentacion);
            ViewBag.Higiene = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Higiene);
            return View(aNoPatologico);
        }

        // GET: ANoPatologicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANoPatologico aNoPatologico = db.ANoPatologico.Find(id);
            if (aNoPatologico == null)
            {
                return HttpNotFound();
            }
            ViewBag.Alimentacion = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Alimentacion);
            ViewBag.Higiene = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Higiene);
            return View(aNoPatologico);
        }

        // POST: ANoPatologicoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Higiene,Alimentacion,VecesCepillado,PersonasEnCasa,PracticaDeporte,ConsumeAlcohol,Embarazada,Grado")] ANoPatologico aNoPatologico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aNoPatologico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Alimentacion = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Alimentacion);
            ViewBag.Higiene = new SelectList(db.Grado, "Identificador", "Descripcion", aNoPatologico.Higiene);
            return View(aNoPatologico);
        }

        // GET: ANoPatologicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANoPatologico aNoPatologico = db.ANoPatologico.Find(id);
            if (aNoPatologico == null)
            {
                return HttpNotFound();
            }
            return View(aNoPatologico);
        }

        // POST: ANoPatologicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ANoPatologico aNoPatologico = db.ANoPatologico.Find(id);
            db.ANoPatologico.Remove(aNoPatologico);
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
