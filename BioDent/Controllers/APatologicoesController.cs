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
    public class APatologicoesController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: APatologicoes
        public ActionResult Index()
        {
            return View(db.APatologico.ToList());
        }

        // GET: APatologicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APatologico aPatologico = db.APatologico.Find(id);
            if (aPatologico == null)
            {
                return HttpNotFound();
            }
            return View(aPatologico);
        }

        // GET: APatologicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: APatologicoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,EnfermedadGrave,Traumatismo,Transfunciones,Hemorragias,Donadores,Alergias,ConsumeMedicamento,AccidenteTratamiento")] APatologico aPatologico)
        {
            if (ModelState.IsValid)
            {
                db.APatologico.Add(aPatologico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aPatologico);
        }

        // GET: APatologicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APatologico aPatologico = db.APatologico.Find(id);
            if (aPatologico == null)
            {
                return HttpNotFound();
            }
            return View(aPatologico);
        }

        // POST: APatologicoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,EnfermedadGrave,Traumatismo,Transfunciones,Hemorragias,Donadores,Alergias,ConsumeMedicamento,AccidenteTratamiento")] APatologico aPatologico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aPatologico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aPatologico);
        }

        // GET: APatologicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            APatologico aPatologico = db.APatologico.Find(id);
            if (aPatologico == null)
            {
                return HttpNotFound();
            }
            return View(aPatologico);
        }

        // POST: APatologicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            APatologico aPatologico = db.APatologico.Find(id);
            db.APatologico.Remove(aPatologico);
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
