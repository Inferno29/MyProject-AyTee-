using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;
using System.Data.Entity;
using MyProjectForWork.Repository;
using MyProjectForWork.Views.Repository;

namespace MyProjectForWork.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private ApplicationDbContext _context;


       
        
        public WorkersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            //_context = new ApplicationDbContext();
        }

        //protected override void Dispose(bool disposing)
        //{
            
        //   _context.Dispose();
        //}

        // GET: Workers
        public ActionResult AboutMe()
        {
            var work = _unitOfWork.Workers.Find(worker => worker.Name == "Spongebob").SingleOrDefault();
        
            //var workers = _context.Workers.
            //    Include(q => q.JobField).
            //    Where(w => w.Name == "Patrick")
            //    .SingleOrDefault();

            
            if(work != null) return View(work);
            throw new HttpException("Worker does not exist");
        }
    }
}