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
    public class EIntraOralsController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: EIntraOrals
        public ActionResult Index()
        {
            return View(db.EIntraOral.ToList());
        }

        // GET: EIntraOrals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EIntraOral eIntraOral = db.EIntraOral.Find(id);
            if (eIntraOral == null)
            {
                return HttpNotFound();
            }
            return View(eIntraOral);
        }

        // GET: EIntraOrals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EIntraOrals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Labios,PaladarDuro,PaladarBlando,Farinje,PisoBoca,GlandulasSalivales,TamanioFormaDiente,ProcesoAlveolares,EstadoGeneral")] EIntraOral eIntraOral)
        {
            if (ModelState.IsValid)
            {
                db.EIntraOral.Add(eIntraOral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eIntraOral);
        }

        // GET: EIntraOrals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EIntraOral eIntraOral = db.EIntraOral.Find(id);
            if (eIntraOral == null)
            {
                return HttpNotFound();
            }
            return View(eIntraOral);
        }

        // POST: EIntraOrals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Labios,PaladarDuro,PaladarBlando,Farinje,PisoBoca,GlandulasSalivales,TamanioFormaDiente,ProcesoAlveolares,EstadoGeneral")] EIntraOral eIntraOral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eIntraOral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eIntraOral);
        }

        // GET: EIntraOrals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EIntraOral eIntraOral = db.EIntraOral.Find(id);
            if (eIntraOral == null)
            {
                return HttpNotFound();
            }
            return View(eIntraOral);
        }

        // POST: EIntraOrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EIntraOral eIntraOral = db.EIntraOral.Find(id);
            db.EIntraOral.Remove(eIntraOral);
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
