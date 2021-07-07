using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;
using System.Data.Entity;

namespace MyProjectForWork.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;
        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ShowBooks()
        {
            var ratings = _context.Ratings.ToList();
            var books = _context.Books.Include(xmldddd => xmldddd.Rating).ToList();
            var viewModel = new BookViewModel
            {
                Ratings = ratings, 
                Books = books
             
            };

            return View(viewModel); 
        }
    }
}