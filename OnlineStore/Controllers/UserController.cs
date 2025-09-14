using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineStore.Context;
using OnlineStore.Models;
using System.Linq;

namespace OnlineStore.Controllers
{
    public class UserController : Controller
    {
        private static myContext db = new myContext();
        // view to login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User _user)
        {
            if(_user != null)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == _user.Email);
                if (user == null)
                {
                    ModelState.AddModelError("Email", "Email is not found");
                    return View();
                }
                if (user.Password != _user.Password)
                {
                    ModelState.AddModelError("Password", "Incorrect Password");
                    return View();
                }
                HomeController.Name = user.FirstName + " " + user.LastName;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HomeController.Name = "Guest";
            return RedirectToAction("Index", "Home");
        }
        //view to show table of all users
        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }
        // view to show more details
        public IActionResult Details(int id)
        {
            var user = db.Users.Find(id);
            if(user == null)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }
        // View to show form to add new user
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // View to add new user in DB
        [HttpPost]
        public IActionResult Create(User _user)
        {
            if (_user != null)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == _user.Email);
                if (user != null)
                {
                    ModelState.AddModelError("Email", "Email is alread exists. Use different one");
                    return View();
                }
                if (ModelState.IsValid)
                {
                    db.Users.Add(_user);
                    db.SaveChanges();
                    HomeController.Name = _user.FirstName + " " + _user.LastName;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        // view to show form of user info to edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = db.Users.Find(id);
            if(user == null)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }
        // view to edit user info in DB
        [HttpPost]
        public IActionResult Edit(User _user)
        {
            if(_user != null)
            {
                var userToUpdate = db.Users.Find(_user.UserId);
                ModelState.Remove("ConfirmPassword");
                if (userToUpdate != null && ModelState.IsValid)
                {
                    userToUpdate.FirstName = _user.FirstName;
                    userToUpdate.LastName = _user.LastName;
                    userToUpdate.Email = _user.Email;
                    userToUpdate.Password = _user.Password;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(_user);
        }
        [HttpGet]
        // view to show message to delete user
        public IActionResult Delete(int id) 
        {
            var user = db.Users.Find(id);
            if(user == null)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [HttpPost]
        // view to remove user from database
        public IActionResult Delete(User user)
        {
            var userToRemove = db.Users.Find(user.UserId);
            if (userToRemove == null)
            {
                return View();
            }
            db.Users.Remove(userToRemove);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


