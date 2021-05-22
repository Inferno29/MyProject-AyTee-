using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.Views.Repository
{
    public class JobFieldRepository : Repository<JobField>, IJobFieldRepository
    {
        public JobFieldRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}