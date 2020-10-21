using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExpDigital.Models;

namespace ExpDigital.Controllers
{
    public class DesarrolloSoftwareController : Controller
    {
        private ExpedienteDigitalEntities db = new ExpedienteDigitalEntities();

        // GET: DesarrolloSoftware
        public ActionResult Index()
        {
            return View(db.DesarrolloSoftwares.ToList());
        }

        // GET: DesarrolloSoftware/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesarrolloSoftware desarrolloSoftware = db.DesarrolloSoftwares.Find(id);
            if (desarrolloSoftware == null)
            {
                return HttpNotFound();
            }
            return View(desarrolloSoftware);
        }

        // GET: DesarrolloSoftware/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DesarrolloSoftware/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombre,numeroAutores")] DesarrolloSoftware desarrolloSoftware)
        {
            if (ModelState.IsValid)
            {
                db.DesarrolloSoftwares.Add(desarrolloSoftware);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(desarrolloSoftware);
        }

        // GET: DesarrolloSoftware/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesarrolloSoftware desarrolloSoftware = db.DesarrolloSoftwares.Find(id);
            if (desarrolloSoftware == null)
            {
                return HttpNotFound();
            }
            return View(desarrolloSoftware);
        }

        // POST: DesarrolloSoftware/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombre,numeroAutores")] DesarrolloSoftware desarrolloSoftware)
        {
            if (ModelState.IsValid)
            {
                db.Entry(desarrolloSoftware).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(desarrolloSoftware);
        }

        // GET: DesarrolloSoftware/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DesarrolloSoftware desarrolloSoftware = db.DesarrolloSoftwares.Find(id);
            if (desarrolloSoftware == null)
            {
                return HttpNotFound();
            }
            return View(desarrolloSoftware);
        }

        // POST: DesarrolloSoftware/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DesarrolloSoftware desarrolloSoftware = db.DesarrolloSoftwares.Find(id);
            db.DesarrolloSoftwares.Remove(desarrolloSoftware);
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
