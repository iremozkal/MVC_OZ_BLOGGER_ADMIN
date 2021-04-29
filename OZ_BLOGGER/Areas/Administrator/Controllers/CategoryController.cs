using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OZ_BLOGGER.Infrastructure.Repository;
using OZ_BLOGGER.Models.Entity;

namespace OZ_BLOGGER.Areas.Administrator.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Repository<Category> BlogRepo;

        public CategoryController()
        {
            BlogRepo = new Repository<Category>();
        }

        // GET: Administrator/Category
        public ActionResult ListCategories()
        {
            return View(BlogRepo.GetAll());
        }

        [HttpPost]
        public ActionResult Update(string txtCategoryName, int hdnCategoryId)
        {
            Category cateogry = BlogRepo.GetById(hdnCategoryId);
            cateogry.CategoryName = txtCategoryName;
            cateogry.UpdatedAt = DateTime.Now;
            BlogRepo.Update(cateogry);

            return RedirectToAction("ListCategories", "Category");
        }

        [HttpPost]
        public ActionResult Add(string txtAddCategoryName)
        {
            Category category = new Category()
            {
                CategoryName = txtAddCategoryName,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                isActive = true
            };
            BlogRepo.Add(category);

            return RedirectToAction("ListCategories", "Category");
        }

        public ActionResult Pacify(int Id)
        {
            Category category = BlogRepo.GetById(Id);
            category.isActive = false;
            category.UpdatedAt = DateTime.Now;
            BlogRepo.Update(category);

            return RedirectToAction("ListCategories", "Category");
        }

        public ActionResult Activate(int Id)
        {
            Category category = BlogRepo.GetById(Id);
            category.isActive = true;
            category.UpdatedAt = DateTime.Now;
            BlogRepo.Update(category);

            return RedirectToAction("ListCategories", "Category");
        }

        [HttpPost]
        public ActionResult HardDelete(int hdnDeletedId)
        {
            Category category = BlogRepo.GetById(hdnDeletedId);
            BlogRepo.Delete(category);

            return RedirectToAction("ListCategories", "Category");
        }
    }
}