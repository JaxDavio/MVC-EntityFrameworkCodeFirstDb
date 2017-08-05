using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LegoArchitecture.Models;

namespace LegoArchitecture.Controllers
{
    public class HomeController : Controller
    {
        private LegoReviewContext db = new LegoReviewContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Legos.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lego lego = db.Legos.Find(id);
            if (lego == null)
            {
                return HttpNotFound();
            }
            return View(lego);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ArchitectureName,Description,ReleaseDate")] Lego lego)
        {
            if (ModelState.IsValid)
            {
                db.Legos.Add(lego);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lego);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lego lego = db.Legos.Find(id);
            if (lego == null)
            {
                return HttpNotFound();
            }
            return View(lego);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArchitectureName,Description,ReleaseDate")] Lego lego)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lego).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lego);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lego lego = db.Legos.Find(id);
            if (lego == null)
            {
                return HttpNotFound();
            }
            return View(lego);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lego lego = db.Legos.Find(id);
            db.Legos.Remove(lego);
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
