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
    public class ObraAdministrativaDesarrolloController : Controller
    {
        private ExpedienteDigitalEntities db = new ExpedienteDigitalEntities();

        // GET: ObraAdministrativaDesarrollo
        public ActionResult Index()
        {
            var obraAdministrativaDesarrolloes = db.ObraAdministrativaDesarrolloes.Include(o => o.TipoObraAdmi);
            return View(obraAdministrativaDesarrolloes.ToList());
        }

        // GET: ObraAdministrativaDesarrollo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraAdministrativaDesarrollo obraAdministrativaDesarrollo = db.ObraAdministrativaDesarrolloes.Find(id);
            if (obraAdministrativaDesarrollo == null)
            {
                return HttpNotFound();
            }
            return View(obraAdministrativaDesarrollo);
        }

        // GET: ObraAdministrativaDesarrollo/Create
        public ActionResult Create()
        {
            ViewBag.id_tipo = new SelectList(db.TipoObraAdmis, "ID", "nombre");
            return View();
        }

        // POST: ObraAdministrativaDesarrollo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,titulo,numeroAutores,id_tipo")] ObraAdministrativaDesarrollo obraAdministrativaDesarrollo)
        {
            if (ModelState.IsValid)
            {
                db.ObraAdministrativaDesarrolloes.Add(obraAdministrativaDesarrollo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_tipo = new SelectList(db.TipoObraAdmis, "ID", "nombre", obraAdministrativaDesarrollo.id_tipo);
            return View(obraAdministrativaDesarrollo);
        }

        // GET: ObraAdministrativaDesarrollo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraAdministrativaDesarrollo obraAdministrativaDesarrollo = db.ObraAdministrativaDesarrolloes.Find(id);
            if (obraAdministrativaDesarrollo == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_tipo = new SelectList(db.TipoObraAdmis, "ID", "nombre", obraAdministrativaDesarrollo.id_tipo);
            return View(obraAdministrativaDesarrollo);
        }

        // POST: ObraAdministrativaDesarrollo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,titulo,numeroAutores,id_tipo")] ObraAdministrativaDesarrollo obraAdministrativaDesarrollo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obraAdministrativaDesarrollo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_tipo = new SelectList(db.TipoObraAdmis, "ID", "nombre", obraAdministrativaDesarrollo.id_tipo);
            return View(obraAdministrativaDesarrollo);
        }

        // GET: ObraAdministrativaDesarrollo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraAdministrativaDesarrollo obraAdministrativaDesarrollo = db.ObraAdministrativaDesarrolloes.Find(id);
            if (obraAdministrativaDesarrollo == null)
            {
                return HttpNotFound();
            }
            return View(obraAdministrativaDesarrollo);
        }

        // POST: ObraAdministrativaDesarrollo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObraAdministrativaDesarrollo obraAdministrativaDesarrollo = db.ObraAdministrativaDesarrolloes.Find(id);
            db.ObraAdministrativaDesarrolloes.Remove(obraAdministrativaDesarrollo);
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
