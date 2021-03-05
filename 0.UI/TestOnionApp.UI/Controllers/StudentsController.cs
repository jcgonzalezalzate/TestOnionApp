using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOnionApp.Application.Interfaces;
using TestOnionApp.Domain.Entities;

namespace TestOnionApp.UI.Controllers
{
    public class StudentsController : Controller
    {
        protected readonly IStudentApplication StudentApplication;

        public StudentsController(IStudentApplication studentApplication)
        {
            this.StudentApplication = studentApplication;
        }

        // GET: StudentsController
        public ActionResult Index()
        {
            return View(this.StudentApplication.GetAll());
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View(this.StudentApplication.Details(id));
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                this.StudentApplication.Create(student);

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            var student = this.StudentApplication.Details(id);
            return View(student);
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            if (ModelState.IsValid)
            {
                this.StudentApplication.Edit(student);

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            var student = this.StudentApplication.Details(id);
            return View(student);
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            this.StudentApplication.Delete(id);

            return View(student);
        }
    }
}
