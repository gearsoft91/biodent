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
    public class EExtraOralsController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: EExtraOrals
        public ActionResult Index()
        {
            return View(db.EExtraOral.ToList());
        }

        // GET: EExtraOrals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EExtraOral eExtraOral = db.EExtraOral.Find(id);
            if (eExtraOral == null)
            {
                return HttpNotFound();
            }
            return View(eExtraOral);
        }

        // GET: EExtraOrals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EExtraOrals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Cabeza,Cuello,GangliosCervicales")] EExtraOral eExtraOral)
        {
            if (ModelState.IsValid)
            {
                db.EExtraOral.Add(eExtraOral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eExtraOral);
        }

        // GET: EExtraOrals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EExtraOral eExtraOral = db.EExtraOral.Find(id);
            if (eExtraOral == null)
            {
                return HttpNotFound();
            }
            return View(eExtraOral);
        }

        // POST: EExtraOrals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Cabeza,Cuello,GangliosCervicales")] EExtraOral eExtraOral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eExtraOral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eExtraOral);
        }

        // GET: EExtraOrals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EExtraOral eExtraOral = db.EExtraOral.Find(id);
            if (eExtraOral == null)
            {
                return HttpNotFound();
            }
            return View(eExtraOral);
        }

        // POST: EExtraOrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EExtraOral eExtraOral = db.EExtraOral.Find(id);
            db.EExtraOral.Remove(eExtraOral);
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
