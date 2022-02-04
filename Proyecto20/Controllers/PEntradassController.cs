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
    public class PEntradassController : Controller
    {
        private GeneralContext db = new GeneralContext();

        // GET: PEntradass
        public ActionResult Index()
        {
            var pEntradas = db.PEntradas.Include(p => p.Proveedores).Include(p => p.Sucursales);
            return View(pEntradas.ToList());
        }

        // GET: PEntradass/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEntrada pEntrada = db.PEntradas.Find(id);
            if (pEntrada == null)
            {
                return HttpNotFound();
            }
            return View(pEntrada);
        }

        // GET: PEntradass/Create
        public ActionResult Create()
        {
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor");
            ViewBag.ID_Sucursal = new SelectList(db.Sucursales, "ID_Sucursal", "Nsucursal");
            return View();
        }

        // POST: PEntradass/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Entrada,Usuario,Usuario_Cancelacion,ID_Sucursal,ID_Proveedor,Referencia,Fecha_Captura,Fecha_Cancelacion,Motivo_Cancelacion,Comentarios,Status")] PEntrada pEntrada)
        {
            if (ModelState.IsValid)
            {
                db.PEntradas.Add(pEntrada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", pEntrada.ID_Proveedor);
            ViewBag.ID_Sucursal = new SelectList(db.Sucursales, "ID_Sucursal", "Nsucursal", pEntrada.ID_Sucursal);
            return View(pEntrada);
        }

        // GET: PEntradass/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEntrada pEntrada = db.PEntradas.Find(id);
            if (pEntrada == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", pEntrada.ID_Proveedor);
            ViewBag.ID_Sucursal = new SelectList(db.Sucursales, "ID_Sucursal", "Nsucursal", pEntrada.ID_Sucursal);
            return View(pEntrada);
        }

        // POST: PEntradass/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Entrada,Usuario,Usuario_Cancelacion,ID_Sucursal,ID_Proveedor,Referencia,Fecha_Captura,Fecha_Cancelacion,Motivo_Cancelacion,Comentarios,Status")] PEntrada pEntrada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pEntrada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Proveedor = new SelectList(db.Proveedores, "ID_Proveedor", "Nproveedor", pEntrada.ID_Proveedor);
            ViewBag.ID_Sucursal = new SelectList(db.Sucursales, "ID_Sucursal", "Nsucursal", pEntrada.ID_Sucursal);
            return View(pEntrada);
        }

        // GET: PEntradass/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEntrada pEntrada = db.PEntradas.Find(id);
            if (pEntrada == null)
            {
                return HttpNotFound();
            }
            return View(pEntrada);
        }

        // POST: PEntradass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PEntrada pEntrada = db.PEntradas.Find(id);
            db.PEntradas.Remove(pEntrada);
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
