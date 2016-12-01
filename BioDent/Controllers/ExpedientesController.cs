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
    public class ExpedientesController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: Expedientes
        public ActionResult Index()
        {
            var expediente = db.Expediente.Include(e => e.AHereditario).Include(e => e.ANoPatologico).Include(e => e.AOdontologico).Include(e => e.APatologico).Include(e => e.EATM).Include(e => e.EExtraOral).Include(e => e.EIntraOral).Include(e => e.Odontograma1).Include(e => e.Paciente1);
            return View(expediente.ToList());
        }

        // GET: Expedientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = db.Expediente.Find(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            return View(expediente);
        }

        // GET: Expedientes/Create
        public ActionResult Create()
        {
            ViewBag.Hereditario = new SelectList(db.AHereditario, "Identificador", "FamiliarFallecidoDeEnfermedad");
            ViewBag.NoPatologico = new SelectList(db.ANoPatologico, "Identificador", "PracticaDeporte");
            ViewBag.Odontologico = new SelectList(db.AOdontologico, "Identificador", "TratamientoPrevio");
            ViewBag.Patologico = new SelectList(db.APatologico, "Identificador", "EnfermedadGrave");
            ViewBag.ATM = new SelectList(db.EATM, "Identificador", "TieneDolor");
            ViewBag.ExtraOral = new SelectList(db.EExtraOral, "Identificador", "Cabeza");
            ViewBag.IntraOral = new SelectList(db.EIntraOral, "Identificador", "Labios");
            ViewBag.Odontograma = new SelectList(db.Odontograma, "Identificador", "Pronostico");
            ViewBag.Paciente = new SelectList(db.Paciente, "Identificador", "Nombre");
            return View();
        }

        // POST: Expedientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,FechaExpediente,Paciente,Patologico,NoPatologico,Odontologico,Hereditario,ExtraOral,IntraOral,ATM,Odontograma")] Expediente expediente)
        {
            if (ModelState.IsValid)
            {
                db.Expediente.Add(expediente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Hereditario = new SelectList(db.AHereditario, "Identificador", "FamiliarFallecidoDeEnfermedad", expediente.Hereditario);
            ViewBag.NoPatologico = new SelectList(db.ANoPatologico, "Identificador", "PracticaDeporte", expediente.NoPatologico);
            ViewBag.Odontologico = new SelectList(db.AOdontologico, "Identificador", "TratamientoPrevio", expediente.Odontologico);
            ViewBag.Patologico = new SelectList(db.APatologico, "Identificador", "EnfermedadGrave", expediente.Patologico);
            ViewBag.ATM = new SelectList(db.EATM, "Identificador", "TieneDolor", expediente.ATM);
            ViewBag.ExtraOral = new SelectList(db.EExtraOral, "Identificador", "Cabeza", expediente.ExtraOral);
            ViewBag.IntraOral = new SelectList(db.EIntraOral, "Identificador", "Labios", expediente.IntraOral);
            ViewBag.Odontograma = new SelectList(db.Odontograma, "Identificador", "Pronostico", expediente.Odontograma);
            ViewBag.Paciente = new SelectList(db.Paciente, "Identificador", "Nombre", expediente.Paciente);
            return View(expediente);
        }

        // GET: Expedientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = db.Expediente.Find(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            ViewBag.Hereditario = new SelectList(db.AHereditario, "Identificador", "FamiliarFallecidoDeEnfermedad", expediente.Hereditario);
            ViewBag.NoPatologico = new SelectList(db.ANoPatologico, "Identificador", "PracticaDeporte", expediente.NoPatologico);
            ViewBag.Odontologico = new SelectList(db.AOdontologico, "Identificador", "TratamientoPrevio", expediente.Odontologico);
            ViewBag.Patologico = new SelectList(db.APatologico, "Identificador", "EnfermedadGrave", expediente.Patologico);
            ViewBag.ATM = new SelectList(db.EATM, "Identificador", "TieneDolor", expediente.ATM);
            ViewBag.ExtraOral = new SelectList(db.EExtraOral, "Identificador", "Cabeza", expediente.ExtraOral);
            ViewBag.IntraOral = new SelectList(db.EIntraOral, "Identificador", "Labios", expediente.IntraOral);
            ViewBag.Odontograma = new SelectList(db.Odontograma, "Identificador", "Pronostico", expediente.Odontograma);
            ViewBag.Paciente = new SelectList(db.Paciente, "Identificador", "Nombre", expediente.Paciente);
            return View(expediente);
        }

        // POST: Expedientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,FechaExpediente,Paciente,Patologico,NoPatologico,Odontologico,Hereditario,ExtraOral,IntraOral,ATM,Odontograma")] Expediente expediente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expediente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Hereditario = new SelectList(db.AHereditario, "Identificador", "FamiliarFallecidoDeEnfermedad", expediente.Hereditario);
            ViewBag.NoPatologico = new SelectList(db.ANoPatologico, "Identificador", "PracticaDeporte", expediente.NoPatologico);
            ViewBag.Odontologico = new SelectList(db.AOdontologico, "Identificador", "TratamientoPrevio", expediente.Odontologico);
            ViewBag.Patologico = new SelectList(db.APatologico, "Identificador", "EnfermedadGrave", expediente.Patologico);
            ViewBag.ATM = new SelectList(db.EATM, "Identificador", "TieneDolor", expediente.ATM);
            ViewBag.ExtraOral = new SelectList(db.EExtraOral, "Identificador", "Cabeza", expediente.ExtraOral);
            ViewBag.IntraOral = new SelectList(db.EIntraOral, "Identificador", "Labios", expediente.IntraOral);
            ViewBag.Odontograma = new SelectList(db.Odontograma, "Identificador", "Pronostico", expediente.Odontograma);
            ViewBag.Paciente = new SelectList(db.Paciente, "Identificador", "Nombre", expediente.Paciente);
            return View(expediente);
        }

        // GET: Expedientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = db.Expediente.Find(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            return View(expediente);
        }

        // POST: Expedientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expediente expediente = db.Expediente.Find(id);
            db.Expediente.Remove(expediente);
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
