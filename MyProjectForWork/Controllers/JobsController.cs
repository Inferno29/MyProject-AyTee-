using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;
using System.Data.Entity;
using System.Net;

namespace MyProjectForWork.Controllers
{
    public class JobsController : Controller
    {

        private ApplicationDbContext _context;

        public JobsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }




        // GET: Jobs
        public ActionResult AllJobs()
        {

            var jobs = _context.Jobs.Include(job => job.JobField).ToList();
          

            if (jobs.Count != 0) return View(jobs);

            throw new HttpException("Job List is empty");


        }




       
        public ActionResult ShowJob(string jobName)
        {
            var name = _context.Jobs.Include(job => job.JobField).Where(j => j.JobName == jobName).SingleOrDefault();

            if (name != null) return View(name);

            throw new HttpException("Job does not exist");
        }



        public ActionResult ShowJobField(string jobField)
        {
            var field = _context.JobFields.Where(job => job.Field == jobField).SingleOrDefault();

            if(field != null) return View(field);
            throw new HttpException("Job field does not exist");
        }
    }
}