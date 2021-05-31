using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyProjectForWork.Models;
using MyProjectForWork.Repository;
using MyProjectForWork.ViewModels;


namespace MyProjectForWork.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
      




        public WorkersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;



        }


        [Authorize]
        // GET: Workers
        public ActionResult AboutMe(int workerId)
        {

            var work = _unitOfWork.Workers.GetSingleWorkerWithJobField(workerId);
            if (work != null) return View(work);
            throw new HttpException("Worker does not exist");
        }

        [Authorize]
        public ActionResult EditProfile()
        {
            var jobfields =_unitOfWork.JobFields.GetAll();
            var viewModel = new NewWorkerViewModel()
            {
                JobFields = jobfields,

            };
            return View(viewModel);

        }



        [HttpPost]
        public ActionResult Create(Worker worker)
        {
            _unitOfWork.Workers.Add(worker);
           _unitOfWork.Complete();
           _unitOfWork.Dispose();
           return RedirectToAction("Index", "Home");
        }


        [Authorize]
        public ActionResult GetAllWorkers()
        {
            var allWorkers = _unitOfWork.Workers.GetWorkersWitJobFields();
            return View(allWorkers);
        }


       


    }
}
