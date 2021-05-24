using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public class EmployersRepository : Repository<Employer>, IEmployersRepository
    {
        public EmployersRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        public IEnumerable<Employer> GetAllEmployersWithJobs()
        {
            return Context.Employers.Include(employ => employ.Jobs).ToList();

        }

        public Employer GetSingleEmployerWithJobs(string employerName)
        {
            return Context.Employers
                .Include(emo => emo.Jobs)
                .Where(emp => emp.Name == employerName)
                .SingleOrDefault();
        }
    }
}