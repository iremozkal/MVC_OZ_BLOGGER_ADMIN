using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OZ_BLOGGER.Infrastructure.Repository;
using OZ_BLOGGER.Models.Entity;

namespace OZ_BLOGGER.Areas.Administrator.Controllers
{
    public class BlogController : Controller
    {
        private readonly Repository<Blog> BlogRepo;

        public BlogController()
        {
            BlogRepo = new Repository<Blog>();
        }

        // GET: /Administrator/Blog/
        public ActionResult Index()
        {
            return View(BlogRepo.GetAll());
        }
    }
}
