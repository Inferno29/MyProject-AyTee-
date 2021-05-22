using System;
using System.Collections.Generic;
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
    }
}