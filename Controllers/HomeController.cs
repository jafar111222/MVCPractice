using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;


namespace MVCPractice.Controllers
{
    
    public class HomeController : Controller
    {
        MVCPracticeEntities db = new MVCPracticeEntities();

        public ActionResult Index()
        {
            //HomeViewModel homeViewModel = new HomeViewModel();
            var Categories= db.Categories.Include("SubCategory").Include("Posts").ToList();
            
            //var Categories = db.Categories.Join(db.Posts,
            //                    post => database.Posts.Where(x => x.ID == id),
            //                    meta => database.Post_Metas.Where(x => x.Post_ID == id),
            //                    (post, meta) => new { Post = post, Meta = meta });
            return View(Categories.ToList());

            //public List<Category> GetCategories(string search, int pageNo)
            //{
            //    int pageSize = 10;

            //    using (var context = new MHDbContext())
            //    {
            //        if (!string.IsNullOrEmpty(search))
            //        {
            //            return context.Categories.Where(category => category.Name != null &&
            //                 category.Name.ToLower().Contains(search.ToLower()))
            //                 .OrderBy(x => x.CID)
            //                 .Skip((pageNo - 1) * pageSize)
            //                 .Take(pageSize)
            //                 .Include(x => x.Products)
            //                 .ToList();
            //        }
            //        else
            //        {
            //            return context.Categories
            //                .OrderBy(x => x.CID)
            //                .Skip((pageNo - 1) * pageSize)
            //                .Take(pageSize)
            //                .Include(x => x.Products)
            //                .ToList();
            //        }
            //    }
            //}


            // Post post = new Post();
            //var categories = db.Categories.Include("Posts").Include("SubCategories").ToList();
            //var categories = db.Categories.ToList();
            //var SubCategories = db.SubCategories.ToList();
            //var Author = db.Authors.ToList();
            //var sports = db.Posts.Include(p => p.Author).Include(p => p.Category).Include(p => p.SubCategory).OrderByDescending(p => p.PostID).Take(4);
            //ViewBag.Categories = categories;
            //ViewBag.Subcategories = SubCategories;
            //ViewBag.Author = Author;
            //ViewBag.sports = sports;
            //post.PostID= categories.
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}