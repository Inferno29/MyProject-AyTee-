using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public class WorkersRepository : Repository<Worker>, IWorkersRepository
    {

        public WorkersRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        

        public IEnumerable<Worker> GetWorkersWitJobFields()
        {
            return Context.Workers.Include(work => work.JobField).ToList();
        }

        public Worker GetSingleWorkerWithJobField(int workerId)
        {
            return Context.Workers
                .Include(work => work.JobField)
                .Where(worker => worker.Id == workerId)
                .SingleOrDefault();
        }
    }
}