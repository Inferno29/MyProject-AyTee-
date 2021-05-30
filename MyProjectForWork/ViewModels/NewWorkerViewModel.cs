using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProjectForWork.Models;

namespace MyProjectForWork.ViewModels
{
    public class NewWorkerViewModel
    {
        public IEnumerable<JobField> JobFields { get; set; }
        public Worker Worker { get; set; }
    }
}