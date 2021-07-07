using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectForWork.Models
{
    public class SingleBookViewModel
    {
        public List<Rating> Ratings { get; set; }
        public Book Book { get; set; }
    }
}