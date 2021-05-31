using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyProjectForWork.Repository;

namespace MyProjectForWork.Controllers
{
   
    public class EmployersController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public EmployersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
          
        }

   

        // GET: Employers
        public ActionResult AllEmployers()
        {
            var employer = _unitOfWork.Employers.GetAllEmployersWithJobs();
            if (employer.Count() != 0) return View(employer);

            throw new HttpException("There are no employers");
        }


        public ActionResult ThisEmployer(string employerName)
        {
            var employer = _unitOfWork.Employers.GetSingleEmployerWithJobs(employerName);
            if (employer != null) return View(employer);

            throw new HttpException("You have not selected an employer");
        }
    }
}