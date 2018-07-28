using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App.Core;
using App.Infrastructure;

namespace App.Web.Controllers
{
    public class WhatsNewsController : Controller
    {
        private WhatsNewRepository db = new WhatsNewRepository();

        // GET: WhatsNews
        public ActionResult Index()
        {
            return View(db.GetAll());
        }

        // GET: WhatsNews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhatsNew whatsNew = db.FindById(Convert.ToInt32(id));
            if (whatsNew == null)
            {
                return HttpNotFound();
            }
            return View(whatsNew);
        }

        // GET: WhatsNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WhatsNews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CurrentDate,heading,description")] WhatsNew whatsNew)
        {
            if (ModelState.IsValid)
            {
                db.Add(whatsNew);
                return RedirectToAction("Index");
            }

            return View(whatsNew);
        }

        // GET: WhatsNews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhatsNew whatsNew = db.FindById(Convert.ToInt32(id));
            if (whatsNew == null)
            {
                return HttpNotFound();
            }
            return View(whatsNew);
        }

        // POST: WhatsNews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CurrentDate,heading,description")] WhatsNew whatsNew)
        {
            if (ModelState.IsValid)
            {
                db.Edit(whatsNew);
                   
                return RedirectToAction("Index");
            }
            return View(whatsNew);
        }

        // GET: WhatsNews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WhatsNew whatsNew = db.FindById(Convert.ToInt32(id));
            if (whatsNew == null)
            {
                return HttpNotFound();
            }
            return View(whatsNew);
        }

        // POST: WhatsNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           // WhatsNew whatsNew = db.FindById(Convert.ToInt32(id));
            db.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               // db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
