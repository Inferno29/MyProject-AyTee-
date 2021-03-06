using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public interface IJobRepository : IRepository<Job>
    {
        IEnumerable<Job> GetJobsAndFields();
    }
}