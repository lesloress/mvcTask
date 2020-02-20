using Blog.DAL.EF;
using Blog.DAL.Entities;
using Blog.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HomeTask.Controllers
{
    public class CommentController : Controller
    {
        UnitOfWork unitOfWork;

        private const int size = 6;
        public CommentController()
        {
            unitOfWork = new UnitOfWork(new BlogContext());
        }

        public ActionResult GetComments(IEnumerable<Comment> comments, int page = 0)
        {
            if (comments == null)
                return HttpNotFound();
            int count;
            if (comments != null)
            {
                count = (comments as List<Comment>).Count;
                GetPages(ref comments, page);
            }

            else
                count = 0;

            GetPages(ref comments, page);

            ViewBag.MaxPage = Max(size, count);
            ViewBag.Page = page;
            return PartialView("GetComments",comments);
        }

        [HttpGet]
        public ActionResult GuestRoom(int page = 0)
        {
            IEnumerable<Comment> comments = unitOfWork.Comments.Find(c => c.Article == null).ToList();

            int count; 

            if (comments != null)
            {
                count = (comments as List<Comment>).Count;
                GetPages(ref comments, page);
            }

            else
                count = 0;

            GetPages(ref comments, page);

            ViewBag.MaxPage = Max(size, count);
            ViewBag.Page = page;

            return View(comments);
        }

        [HttpPost]
        public ActionResult GuestRoom(FormCollection formCollection)
        {
            int page = 0;

            unitOfWork.Comments.Add(new Comment
            {
                Name = formCollection["Name"],
                Text = formCollection["Comment"],
                Date = DateTime.Now.Date
            });

            unitOfWork.Complete();

            IEnumerable<Comment> comments = unitOfWork.Comments.GetAll();

            int count = (comments as List<Comment>).Count;

            GetPages(ref comments, page);

            ViewBag.MaxPage = Max(size, count);
            ViewBag.Page = page;

            return View(comments);
        }

        private IEnumerable<Comment> GetPages(ref IEnumerable<Comment> comments, int page = 0)
        {
            comments = comments
                .OrderByDescending(c => c.Date)
                .Skip(page * size)
                .Take(size)
                .ToList();
            return comments;
        }

        private int Max(int size, int count) => (count / size) - (count % size == 0 ? 1 : 0);
    }
}