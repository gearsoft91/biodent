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
    public class EATMsController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: EATMs
        public ActionResult Index()
        {
            return View(db.EATM.ToList());
        }

        // GET: EATMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EATM eATM = db.EATM.Find(id);
            if (eATM == null)
            {
                return HttpNotFound();
            }
            return View(eATM);
        }

        // GET: EATMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EATMs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,TieneDolor,LimitacionApertura,LimitacionMovimiento,RechinaDiente")] EATM eATM)
        {
            if (ModelState.IsValid)
            {
                db.EATM.Add(eATM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eATM);
        }

        // GET: EATMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EATM eATM = db.EATM.Find(id);
            if (eATM == null)
            {
                return HttpNotFound();
            }
            return View(eATM);
        }

        // POST: EATMs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,TieneDolor,LimitacionApertura,LimitacionMovimiento,RechinaDiente")] EATM eATM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eATM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eATM);
        }

        // GET: EATMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EATM eATM = db.EATM.Find(id);
            if (eATM == null)
            {
                return HttpNotFound();
            }
            return View(eATM);
        }

        // POST: EATMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EATM eATM = db.EATM.Find(id);
            db.EATM.Remove(eATM);
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
