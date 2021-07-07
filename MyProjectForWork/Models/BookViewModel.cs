using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectForWork.Models
{
    public class BookViewModel
    {
        public List<Rating> Ratings { get; set; }
        public List<Book> Books { get; set;  }
    }
}