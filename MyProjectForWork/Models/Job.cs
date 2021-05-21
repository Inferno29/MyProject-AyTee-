using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyProjectForWork.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public JobField JobField { get; set; }
        public int JobFieldId { get; set; }

        [DefaultValue(true)] public bool JobActive { get; set; } = true;
    }
}