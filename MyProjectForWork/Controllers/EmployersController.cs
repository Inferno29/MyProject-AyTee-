using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;

namespace MyProjectForWork.Controllers
{
    public class EmployersController : Controller
    {



        private ApplicationDbContext _context;

        public EmployersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Employers
        public ActionResult AllEmployers()
        {

            var employers = _context.Employers.ToList();
            if (employers.Count != 0) return View(employers);

            throw new HttpException("There are no employers");
        }


        public ActionResult ThisEmployer(string employerName)
        {
            var employer = _context.Employers.Where(e => e.Name == employerName).SingleOrDefault();
            if (employer != null) return View(employer);

            throw new HttpException("You have not selected an employer");
        }
    }
}