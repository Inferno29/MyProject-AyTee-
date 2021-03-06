using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public interface IWorkersRepository : IRepository<Worker>
    {
        IEnumerable<Worker> GetWorkersWitJobFields();
        Worker GetSingleWorkerWithJobField(int workerId);

    }
}