using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;
using MyProjectForWork.Views.Repository;

namespace MyProjectForWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Workers = new WorkersRepository(_context);
            Jobs = new JobRepository(_context);
            JobFields = new JobFieldRepository(_context);
            Employers = new EmployersRepository(_context);
        }

        public IJobRepository Jobs { get; private set; }

        public IWorkersRepository Workers { get; private set; }
        public IJobFieldRepository JobFields { get; private set; }
        public IEmployersRepository Employers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }
    }
}