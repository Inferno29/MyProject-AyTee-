using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProjectForWork.Models
{
    public class Worker
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Adress { get; set; }
        [Required]
        public string UName { get; set; }
        public string About { get; set; }
        public bool AcceptingWork { get; set; }
        public IList<Job> MatchingJobs { get; set; }
        public JobField JobField { get; set; }
        public int JobFieldId { get; set; }

    }
}