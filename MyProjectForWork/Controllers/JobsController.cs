using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Repository;

namespace MyProjectForWork.Controllers
{
    public class JobsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
      

        public JobsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        [Authorize]
        // GET: Jobs
        public ActionResult AllJobs()
        {
            var jobs = _unitOfWork.Jobs.GetJobsAndFields();

            

            if (jobs.Count() != 0) return View(jobs);

            throw new HttpException("Job List is empty");


        }

       
        [Authorize]
        public ActionResult ShowJob(string jobName)
        {
            var name = _unitOfWork.Jobs.Find(job => job.JobName == jobName).SingleOrDefault();
           
            if (name != null) return View(name);

            throw new HttpException("Job does not exist");
        }


        
        public ActionResult ShowJobField(string jobField)
        {
            var fields = _unitOfWork.JobFields.Find(field => field.Field == jobField).SingleOrDefault();


            if(fields != null) return View(fields);
            throw new HttpException("Job field does not exist");
        }
    }
}