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
    public class AlmacensController : Controller
    {
        private GeneralContext db = new GeneralContext();

        // GET: Almacens
        public ActionResult Index()
        {
            var almacenes = db.Almacenes.Include(a => a.Proveedores);
            return View(almacenes.ToList());
        }

        // GET: Almacens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Almacen almacen = db.Almacenes.Find(id);
            if (almacen == null)
            {
                return HttpNotFound();
            }
            return View(almacen);
        }

        // GET: Almacens/Create
        public ActionResult Create()
        {
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor");
            return View();
        }

        // POST: Almacens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Almacen,ID_Proveedor,Fecha,Nproducto,Npresentacion,Cantidad")] Almacen almacen)
        {
            if (ModelState.IsValid)
            {
                db.Almacenes.Add(almacen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", almacen.ID_Proveedor);
            return View(almacen);
        }

        // GET: Almacens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Almacen almacen = db.Almacenes.Find(id);
            if (almacen == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", almacen.ID_Proveedor);
            return View(almacen);
        }

        // POST: Almacens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Almacen,ID_Proveedor,Fecha,Nproducto,Npresentacion,Cantidad")] Almacen almacen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(almacen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", almacen.ID_Proveedor);
            return View(almacen);
        }

        // GET: Almacens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Almacen almacen = db.Almacenes.Find(id);
            if (almacen == null)
            {
                return HttpNotFound();
            }
            return View(almacen);
        }

        // POST: Almacens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Almacen almacen = db.Almacenes.Find(id);
            db.Almacenes.Remove(almacen);
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
