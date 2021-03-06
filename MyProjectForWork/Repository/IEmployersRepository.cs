using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public interface IEmployersRepository : IRepository<Employer>

    {
        IEnumerable<Employer> GetAllEmployersWithJobs();
        Employer GetSingleEmployerWithJobs(string employerName);
    }
}