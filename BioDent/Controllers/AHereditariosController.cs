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
    public class AHereditariosController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: AHereditarios
        public ActionResult Index()
        {
            return View(db.AHereditario.ToList());
        }

        // GET: AHereditarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AHereditario aHereditario = db.AHereditario.Find(id);
            if (aHereditario == null)
            {
                return HttpNotFound();
            }
            return View(aHereditario);
        }

        // GET: AHereditarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AHereditarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,FamiliarFallecidoDeEnfermedad,Causa,FamiliarEnfermo")] AHereditario aHereditario)
        {
            if (ModelState.IsValid)
            {
                db.AHereditario.Add(aHereditario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aHereditario);
        }

        // GET: AHereditarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AHereditario aHereditario = db.AHereditario.Find(id);
            if (aHereditario == null)
            {
                return HttpNotFound();
            }
            return View(aHereditario);
        }

        // POST: AHereditarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,FamiliarFallecidoDeEnfermedad,Causa,FamiliarEnfermo")] AHereditario aHereditario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aHereditario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aHereditario);
        }

        // GET: AHereditarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AHereditario aHereditario = db.AHereditario.Find(id);
            if (aHereditario == null)
            {
                return HttpNotFound();
            }
            return View(aHereditario);
        }

        // POST: AHereditarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AHereditario aHereditario = db.AHereditario.Find(id);
            db.AHereditario.Remove(aHereditario);
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
