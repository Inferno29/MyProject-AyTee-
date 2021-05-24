using System;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Repository;


namespace MyProjectForWork.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
      


       
        
        public WorkersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

           
        }

      

        // GET: Workers
        public ActionResult AboutMe()
        {


            var work = _unitOfWork.Workers.GetSingleWorkerWithJobField("Spongebob");
        
          

            
            if(work != null) return View(work);
            throw new HttpException("Worker does not exist");
        }
    }
}