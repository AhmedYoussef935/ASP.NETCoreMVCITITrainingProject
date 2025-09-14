using Microsoft.AspNetCore.Mvc;
using OnlineStore.Context;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class CategoryController : Controller
    {
        myContext db = new myContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        public IActionResult Details(int id)
        {
            var category = db.Categories.Find(id);
            if(category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(category != null && ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = db.Categories.Find(id);
            if(category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category _category)
        {
            if (_category != null)
            {
                var category = db.Categories.Find(_category.CategoryId);
                if (category != null && ModelState.IsValid)
                {
                    category.CategoryName = _category.CategoryName;
                    category.CategoryDescription = _category.CategoryDescription;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(_category);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = db.Categories.Find(id);
            if( category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category _category)
        {
            if(_category != null)
            {
                var category = db.Categories.Find(_category.CategoryId);
                if (category != null)
                {
                    try
                    {
                        db.Categories.Remove(category);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        TempData["DeleteMessage"] = $"{category.CategoryName} cannot be deleted because it has associated products.";
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(_category);
        }
    }
}
