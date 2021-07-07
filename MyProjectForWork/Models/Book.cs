using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectForWork.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string[] MainActors { get; set; }
        public Rating Rating { get; set; }
        public int RatingId { get; set; }
    }
}