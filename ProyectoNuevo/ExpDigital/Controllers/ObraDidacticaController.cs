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
    public class ObraDidacticaController : Controller
    {
        private ExpedienteDigitalEntities db = new ExpedienteDigitalEntities();

        // GET: ObraDidactica
        public ActionResult Index()
        {
            return View(db.ObraDidacticas.ToList());
        }

        // GET: ObraDidactica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraDidactica obraDidactica = db.ObraDidacticas.Find(id);
            if (obraDidactica == null)
            {
                return HttpNotFound();
            }
            return View(obraDidactica);
        }

        // GET: ObraDidactica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObraDidactica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombre,numeroAutores")] ObraDidactica obraDidactica)
        {
            if (ModelState.IsValid)
            {
                db.ObraDidacticas.Add(obraDidactica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obraDidactica);
        }

        // GET: ObraDidactica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraDidactica obraDidactica = db.ObraDidacticas.Find(id);
            if (obraDidactica == null)
            {
                return HttpNotFound();
            }
            return View(obraDidactica);
        }

        // POST: ObraDidactica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombre,numeroAutores")] ObraDidactica obraDidactica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obraDidactica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obraDidactica);
        }

        // GET: ObraDidactica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraDidactica obraDidactica = db.ObraDidacticas.Find(id);
            if (obraDidactica == null)
            {
                return HttpNotFound();
            }
            return View(obraDidactica);
        }

        // POST: ObraDidactica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObraDidactica obraDidactica = db.ObraDidacticas.Find(id);
            db.ObraDidacticas.Remove(obraDidactica);
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
