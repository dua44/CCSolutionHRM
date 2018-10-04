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
    public class EmployeesController : Controller
    {
        private CCSolutionContext db = new CCSolutionContext();

        // GET: Employees
        public ActionResult Index()
        {
            return GetCustomEmployee();
            //return View(db.Employees.ToList());
        }

        public ActionResult GetCustomEmployee()
        {
            string Query = @"select e.Id,
            e.CompanyId,
            e.[Name] as EmployeeName,
            e.EmailAddress,
            e.DateOfBirth,
            e.GenderId,
            e.NationalityId,
            e.DialingCode1,
            e.PhoneNumber1,
            e.DialingCode2,
            e.PhoneNumber2,
            e.CurrentAddress,
            e.PermenantAddress,
            e.[Delete],
            e.CreationDate,
            g.[Name] as Gender,
            n.[Name] as Nationality,
            c.[Name] as Company
            from dbo.Employee e (nolock)
            inner join dbo.Gender g (nolock) on g.id = e.genderid
            inner join dbo.Nationality n (nolock) on n.id = e.nationalityid
            inner join dbo.Company c (nolock) on c.Id = e.CompanyId
            order by e.CreationDate";
            List<CustomEmployee> objCE = db.Database.SqlQuery<CustomEmployee>(Query).ToList();
            return View(objCE);
        }


        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            List<Company> objcompany = db.Companys.ToList();
            if (objcompany != null)
            {
                var items = new List<SelectListItem>();
                foreach (var company in objcompany)
                {
                    items.Add(new SelectListItem() { Text = company.Name, Value = company.ID.ToString(), Selected = company.ID == employee.CompanyId ? true : false });
                }

                ViewBag.CompaniesList = items;
            }
            else
            {
                return HttpNotFound();
            }


            List<Gender> objGender = db.Genders.ToList();
            if (objGender != null)
            {
                var genders = new List<SelectListItem>();
                foreach (var gender in objGender)
                {
                    genders.Add(new SelectListItem() { Text = gender.Name, Value = gender.ID.ToString(), Selected = gender.ID == employee.GenderId ? true : false });
                }
                ViewBag.GenderList = genders;
            }
            else
            {
                return HttpNotFound();
            }

            List<Nationality> objNationality = db.Nationalitys.ToList();
            if (objGender != null)
            {
                var nationals = new List<SelectListItem>();
                foreach (var nationality in objNationality)
                {
                    nationals.Add(new SelectListItem() { Text = nationality.Name, Value = nationality.ID.ToString(), Selected = nationality.ID == employee.NationalityId ? true : false });
                }
                ViewBag.NationalityList = nationals;
            }
            else
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CompanyId,Name,EmailAddress,DateOfBirth,GenderId,NationalityId,DialingCode1,PhoneNumber1,DialingCode2,PhoneNumber2,CurrentAddress,PermenantAddress,Delete,CreationDate,CreationIP,CreationBy,UpdationDate,UpdationIP,UpdationBy")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            
            Users createdBy = db.Userss.Find(employee.CreationBy);
            Users updatedBy = db.Userss.Find(employee.UpdationBy);

            if (createdBy != null)
            {
                ViewBag.CreatedBy = createdBy;
            }

            if (updatedBy != null)
            {
                ViewBag.UpdatedBy = updatedBy;
            }

            List<Company> objcompany = db.Companys.ToList();
            if (objcompany != null)
            {
                var items = new List<SelectListItem>();
                foreach (var company in objcompany)
                {
                    items.Add(new SelectListItem() { Text = company.Name, Value = company.ID.ToString(), Selected = company.ID == employee.CompanyId ? true : false });
                }

                ViewBag.CompaniesList = items;
            }
            else
            {
                return HttpNotFound();
            }


            List<Gender> objGender = db.Genders.ToList();
            if (objGender != null)
            {
                var genders = new List<SelectListItem>();
                foreach (var gender in objGender)
                {
                    genders.Add(new SelectListItem() { Text = gender.Name, Value = gender.ID.ToString(), Selected = gender.ID == employee.GenderId ? true : false });
                }
                ViewBag.GenderList = genders;
            }
            else
            {
                return HttpNotFound();
            }

            List<Nationality> objNationality = db.Nationalitys.ToList();
            if (objGender != null)
            {
                var nationals = new List<SelectListItem>();
                var phonenumber = new List<SelectListItem>();
                var altphonenumber = new List<SelectListItem>();
                foreach (var nationality in objNationality)
                {
                    nationals.Add(new SelectListItem() { Text = nationality.Name, Value = nationality.ID.ToString(), Selected = nationality.ID == employee.NationalityId ? true : false });
                    phonenumber.Add(new SelectListItem()
                    {
                        Text = nationality.Name + " [+" + nationality.DialingCode.ToString() + "]",
                        Value = nationality.DialingCode.ToString()
                        ,
                        Selected = nationality.DialingCode == employee.DialingCode1 ? true : false
                    });
                    altphonenumber.Add(new SelectListItem()
                    {
                        Text = nationality.Name + " [+" + nationality.DialingCode.ToString() + "]",
                        Value = nationality.DialingCode.ToString()
                        ,
                        Selected = nationality.DialingCode == employee.DialingCode2 ? true : false
                    });
                }
                ViewBag.NationalityList = nationals;
                ViewBag.PhoneNumber = phonenumber;
                ViewBag.AlternatePhoneNumber = altphonenumber;

            }
            else
            {
                return HttpNotFound();
            }


            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CompanyId,Name,EmailAddress,DateOfBirth,GenderId,NationalityId,DialingCode1,PhoneNumber1,DialingCode2,PhoneNumber2,CurrentAddress,PermenantAddress,Delete,CreationDate,CreationIP,CreationBy,UpdationDate,UpdationIP,UpdationBy")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
