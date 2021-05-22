﻿using System;
using System.Collections.Generic;
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

    }
}