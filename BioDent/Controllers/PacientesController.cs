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
    public class PacientesController : Controller
    {
        private DB_DentistaEntities db = new DB_DentistaEntities();

        // GET: Pacientes
        public ActionResult Index(string ordenarPor, string nombreBuscar)
        {
            ViewBag.ordenarPorParm = String.IsNullOrEmpty(ordenarPor) ? "nombre_desc" : "";
            var pacientes = db.Paciente.ToList();

            if (!String.IsNullOrEmpty(nombreBuscar))
            {
                pacientes = pacientes.Where(p => p.Nombre.ToUpper().Contains(nombreBuscar.ToUpper())).ToList();
            }

            switch (ordenarPor)
            {
                case "nombre_desc":
                    pacientes = pacientes.OrderBy(s => s.Nombre).ToList();
                    break;
                case "ap_pat_desc":
                    pacientes = pacientes.OrderBy(s => s.ApellidoPaterno).ToList();
                    break;
                case "ap_mat_desc":
                    pacientes = pacientes.OrderBy(s => s.ApellidoMaterno).ToList();
                    break;
                case "seudonimo":
                    pacientes = pacientes.OrderBy(s => s.Seudominio).ToList();
                    break;
                default:
                    pacientes = pacientes.OrderBy(s => s.Nombre).ToList();
                    break;
            }


            return View(pacientes);
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Nombre,ApellidoPaterno,ApellidoMaterno,Seudominio,LugarNacimiento,FechaNacimiento,Escolaridad,Tutor,EstadoCivil,Domicilio")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Paciente.Add(paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Nombre,ApellidoPaterno,ApellidoMaterno,Seudominio,LugarNacimiento,FechaNacimiento,Escolaridad,Tutor,EstadoCivil,Domicilio")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Paciente.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paciente paciente = db.Paciente.Find(id);
            db.Paciente.Remove(paciente);
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
