using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CCSolutionHRM.DAL;
using CCSolutionHRM.Models;

namespace CCSolutionHRM.Controllers
{
    public class EmployeeDocumentsController : Controller
    {
        private CCSolutionContext db = new CCSolutionContext();

        // GET: EmployeeDocuments
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employeeDocuments = db.EmployeeDocuments.Include(e => e.Document).Include(e => e.Employee).Where(x => x.EmployeeId == id);
            return View(employeeDocuments.ToList());
        }

        // GET: EmployeeDocuments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDocument employeeDocument = db.EmployeeDocuments.Find(id);
            if (employeeDocument == null)
            {
                return HttpNotFound();
            }
            return View(employeeDocument);
        }

        // GET: EmployeeDocuments/Create
        public ActionResult Create()
        {
            ViewBag.DocumentId = new SelectList(db.Documents, "ID", "Name");
            ViewBag.EmployeeId = new SelectList(db.Employees, "ID", "Name");
            return View();
        }

        // POST: EmployeeDocuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EmployeeId,DocumentId,PhysicalLocation,DocumentNumber,NationalityId,IssueDate,ExpiryDate,Comments,Delete,CreationDate,CreationIP,CreationBy,UpdationDate,UpdationIP,UpdationBy")] EmployeeDocument employeeDocument)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDocuments.Add(employeeDocument);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DocumentId = new SelectList(db.Documents, "ID", "Name", employeeDocument.DocumentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "ID", "Name", employeeDocument.EmployeeId);
            return View(employeeDocument);
        }

        // GET: EmployeeDocuments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDocument employeeDocument = db.EmployeeDocuments.Find(id);
            if (employeeDocument == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocumentId = new SelectList(db.Documents, "ID", "Name", employeeDocument.DocumentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "ID", "Name", employeeDocument.EmployeeId);
            return View(employeeDocument);
        }

        // POST: EmployeeDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EmployeeId,DocumentId,PhysicalLocation,DocumentNumber,NationalityId,IssueDate,ExpiryDate,Comments,Delete,CreationDate,CreationIP,CreationBy,UpdationDate,UpdationIP,UpdationBy")] EmployeeDocument employeeDocument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeDocument).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index/" + employeeDocument.EmployeeId);
            }
            ViewBag.DocumentId = new SelectList(db.Documents, "ID", "Name", employeeDocument.DocumentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "ID", "Name", employeeDocument.EmployeeId);            
            return View(employeeDocument);
        }

        // GET: EmployeeDocuments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDocument employeeDocument = db.EmployeeDocuments.Find(id);
            if (employeeDocument == null)
            {
                return HttpNotFound();
            }
            return View(employeeDocument);
        }

        // POST: EmployeeDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDocument employeeDocument = db.EmployeeDocuments.Find(id);
            db.EmployeeDocuments.Remove(employeeDocument);
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
