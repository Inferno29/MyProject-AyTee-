using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Views.Repository;

namespace MyProjectForWork.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IWorkersRepository Workers { get; }
        IJobRepository Jobs { get;}

        IJobFieldRepository JobFields { get; }
        IEmployersRepository Employers { get; }

        int Complete();
    }
}