using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Context;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {
        myContext db = new myContext();
        public IActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).ToList();
            var groups = products.GroupBy(p => p.Category.CategoryName);
            return View(groups);
        }
        public IActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ModelState.Remove("Category");
            if (product != null && ModelState.IsValid)
            {
                if (product.ImagePath == null)
                {
                    product.ImagePath = "~/Styles/Product.png";
                }
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                ViewBag.Categories = new SelectList(db.Categories.ToList(), "CategoryId", "CategoryName");
                return View(product);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Product _product)
        {
            if (_product != null)
            {
                Console.WriteLine(_product);
                var product = db.Products.Find(_product.ProductId);
                ModelState.Remove("Category");
                if (product != null && ModelState.IsValid)
                {
                    Console.WriteLine("Hello");
                    product.Title = _product.Title;
                    product.Description = _product.Description;
                    product.Price = _product.Price;
                    product.Quantity = _product.Quantity;
                    if (product.ImagePath == null)
                    {
                        product.ImagePath = "~/Styles/Product.png";
                    }
                    else
                    {
                        product.ImagePath = _product.ImagePath;
                    }
                        product.CategoryId = _product.CategoryId;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "CategoryId", "CategoryName");
            return View(_product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Product _product)
        {
            if(_product != null)
            {
                var product = db.Products.Find(_product.ProductId);
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(_product);
        }
    }
}
