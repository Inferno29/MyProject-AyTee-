using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        public IEnumerable<Job> GetJobsAndFields()
        {
            var j = Context.Jobs.Include(jb => jb.JobField).ToList();
            return j;

        }
    }
}