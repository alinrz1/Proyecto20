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
    public class PEDetallessController : Controller
    {
        private GeneralContext db = new GeneralContext();

        // GET: PEDetalless
        public ActionResult Index()
        {
            return View(db.PEDetalles.ToList());
        }

        // GET: PEDetalless/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDetalle pEDetalle = db.PEDetalles.Find(id);
            if (pEDetalle == null)
            {
                return HttpNotFound();
            }
            return View(pEDetalle);
        }

        // GET: PEDetalless/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PEDetalless/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Detalle,Nproducto,Cantidad,Precio,Descuento,IVA,IEPS,Status")] PEDetalle pEDetalle)
        {
            if (ModelState.IsValid)
            {
                db.PEDetalles.Add(pEDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pEDetalle);
        }

        // GET: PEDetalless/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDetalle pEDetalle = db.PEDetalles.Find(id);
            if (pEDetalle == null)
            {
                return HttpNotFound();
            }
            return View(pEDetalle);
        }

        // POST: PEDetalless/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Detalle,Nproducto,Cantidad,Precio,Descuento,IVA,IEPS,Status")] PEDetalle pEDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pEDetalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pEDetalle);
        }

        // GET: PEDetalless/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDetalle pEDetalle = db.PEDetalles.Find(id);
            if (pEDetalle == null)
            {
                return HttpNotFound();
            }
            return View(pEDetalle);
        }

        // POST: PEDetalless/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PEDetalle pEDetalle = db.PEDetalles.Find(id);
            db.PEDetalles.Remove(pEDetalle);
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
