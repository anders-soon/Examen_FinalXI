using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenFinalIX.Models;

namespace ExamenFinalIX.Controllers
{
    public class RegistroMVCController : Controller
    {
        private PearEntities db = new PearEntities();

        // GET: RegistroMVC
        public ActionResult Index()
        {
            var registro = db.Registro.Include(r => r.Telefono1);
            return View(registro.ToList());
        }

        // GET: RegistroMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(registro);
        }

        // GET: RegistroMVC/Create
        public ActionResult Create()
        {
            ViewBag.telefono = new SelectList(db.Telefono, "Id_Telefono", "Id_Telefono");
            return View();
        }

        // POST: RegistroMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_registro,FechaHora,telefono,total")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Registro.Add(registro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.telefono = new SelectList(db.Telefono, "Id_Telefono", "Id_Telefono", registro.telefono);
            return View(registro);
        }

        // GET: RegistroMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            ViewBag.telefono = new SelectList(db.Telefono, "Id_Telefono", "Id_Telefono", registro.telefono);
            return View(registro);
        }

        // POST: RegistroMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_registro,FechaHora,telefono,total")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.telefono = new SelectList(db.Telefono, "Id_Telefono", "Id_Telefono", registro.telefono);
            return View(registro);
        }

        // GET: RegistroMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(registro);
        }

        // POST: RegistroMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registro registro = db.Registro.Find(id);
            db.Registro.Remove(registro);
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
