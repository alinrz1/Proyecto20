using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto20.Models;

namespace Proyecto20.Controllers
{
    public class PresentacionsController : Controller
    {
        private GeneralContext db = new GeneralContext();

        // GET: Presentacions
        public ActionResult Index()
        {
            return View(db.Presentaciones.ToList());
        }

        // GET: Presentacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentacion presentacion = db.Presentaciones.Find(id);
            if (presentacion == null)
            {
                return HttpNotFound();
            }
            return View(presentacion);
        }

        // GET: Presentacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Presentacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Presentaciones,Npresentacion,Descripcion,Codigo,Status")] Presentacion presentacion)
        {
            if (ModelState.IsValid)
            {
                db.Presentaciones.Add(presentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(presentacion);
        }

        // GET: Presentacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentacion presentacion = db.Presentaciones.Find(id);
            if (presentacion == null)
            {
                return HttpNotFound();
            }
            return View(presentacion);
        }

        // POST: Presentacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Presentaciones,Npresentacion,Descripcion,Codigo,Status")] Presentacion presentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(presentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presentacion);
        }

        // GET: Presentacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presentacion presentacion = db.Presentaciones.Find(id);
            if (presentacion == null)
            {
                return HttpNotFound();
            }
            return View(presentacion);
        }

        // POST: Presentacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Presentacion presentacion = db.Presentaciones.Find(id);
            db.Presentaciones.Remove(presentacion);
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
