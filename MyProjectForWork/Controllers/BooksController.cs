using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectForWork.Models;
using System.Data.Entity;

namespace MyProjectForWork.Controllers
{
    [Authorize]
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

        [Authorize]
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


        public ActionResult OpenBook(string bookTitle)
        {
            var book = _context.Books.Include(b => b.Rating).Where(b => b.Title == bookTitle).SingleOrDefault();
            var ratings = _context.Ratings.ToList();

            var viewModel = new SingleBookViewModel()
            {
                Ratings = ratings,
                Book = book

            };

            return View(viewModel); 
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            var bookInDb = _context.Books.Single(b => b.Id == book.Id);

           
            if (book.RatingId != 6 && book.RatingId != null)
            {
                
                bookInDb.NumberOfRatings += 1;
                bookInDb.ListOfRatings += book.RatingId;
                bookInDb.MeanRatingValue = Math.Round((double)bookInDb.ListOfRatings / (double)bookInDb.NumberOfRatings,2);
                bookInDb.RatingId = (int)bookInDb.MeanRatingValue;
             
                _context.SaveChanges();

            }

            return RedirectToAction("ShowBooks", "Books"); 
        }
    }
}