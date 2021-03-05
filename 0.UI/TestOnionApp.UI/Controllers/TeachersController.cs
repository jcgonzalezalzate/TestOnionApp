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
    public class TeachersController : Controller
    {
        protected readonly ITeacherApplication TeacherApplication;

        public TeachersController(ITeacherApplication TeacherApplication)
        {
            this.TeacherApplication = TeacherApplication;
        }

        // GET: TeachersController
        public ActionResult Index()
        {
            return View(this.TeacherApplication.GetAll());
        }

        // GET: TeachersController/Details/5
        public ActionResult Details(int id)
        {
            return View(this.TeacherApplication.Details(id));
        }

        // GET: TeachersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeachersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher Teacher)
        {
            if (ModelState.IsValid)
            {
                this.TeacherApplication.Create(Teacher);

                return RedirectToAction(nameof(Index));
            }
            return View(Teacher);
        }

        // GET: TeachersController/Edit/5
        public ActionResult Edit(int id)
        {
            var Teacher = this.TeacherApplication.Details(id);
            return View(Teacher);
        }

        // POST: TeachersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Teacher Teacher)
        {
            if (ModelState.IsValid)
            {
                this.TeacherApplication.Edit(Teacher);

                return RedirectToAction(nameof(Index));
            }
            return View(Teacher);
        }

        // GET: TeachersController/Delete/5
        public ActionResult Delete(int id)
        {
            var Teacher = this.TeacherApplication.Details(id);
            return View(Teacher);
        }

        // POST: TeachersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Teacher Teacher)
        {
            this.TeacherApplication.Delete(id);

            return View(Teacher);
        }
    }
}
