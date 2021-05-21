using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;
using System.Data.Entity;

namespace MyProjectForWork.Controllers
{
    public class WorkersController : Controller
    {


        private ApplicationDbContext _context;

        public WorkersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Workers
        public ActionResult AboutMe()
        {

            var workers = _context.Workers.
                Include(q => q.JobField).
                Where(w => w.Name == "Patrick")
                .SingleOrDefault();

            
            if(workers != null) return View(workers);
            throw new HttpException("Worker does not exist");
        }
    }
}