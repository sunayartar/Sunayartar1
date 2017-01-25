using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8;

namespace WebApplication8.Controllers
{
    public class personel_1Controller : Controller
    {
        private personelEntities db = new personelEntities();

        // GET: personel_1
        public ActionResult Index()
        {
            return View(db.personel_1.ToList());
        }

        // GET: personel_1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personel_1 personel_1 = db.personel_1.Find(id);
            if (personel_1 == null)
            {
                return HttpNotFound();
            }
            return View(personel_1);
        }

        // GET: personel_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: personel_1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "müşteri_adı,seyahat_gidiş,seyahat_geliş,kişi_sayısı,hangi_bölgeden,hangi_bölgeye")] personel_1 personel_1)
        {
            if (ModelState.IsValid)
            {
                db.personel_1.Add(personel_1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personel_1);
        }

        // GET: personel_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personel_1 personel_1 = db.personel_1.Find(id);
            if (personel_1 == null)
            {
                return HttpNotFound();
            }
            return View(personel_1);
        }

        // POST: personel_1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "müşteri_adı,seyahat_gidiş,seyahat_geliş,kişi_sayısı,hangi_bölgeden,hangi_bölgeye")] personel_1 personel_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personel_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personel_1);
        }

        // GET: personel_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personel_1 personel_1 = db.personel_1.Find(id);
            if (personel_1 == null)
            {
                return HttpNotFound();
            }
            return View(personel_1);
        }

        // POST: personel_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            personel_1 personel_1 = db.personel_1.Find(id);
            db.personel_1.Remove(personel_1);
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
