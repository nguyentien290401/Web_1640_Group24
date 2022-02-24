using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_1640_Group24.Models;

namespace Web_1640_Group24.Controllers
{
    public class AccountController : Controller
    {
        private IdeasDbContext db = new IdeasDbContext();
        // GET: Account
        public ActionResult Index()
        {
            using (IdeasDbContext db = new IdeasDbContext())
            {
                return View(db.Users.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                using (IdeasDbContext db = new IdeasDbContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                return RedirectToAction("Login");
            }
            return View();
        }
        //login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            using (IdeasDbContext db = new IdeasDbContext())
            {
                var usr = db.Users.Single(u => u.Name == user.Name && u.PasswordHash == user.PasswordHash);
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Name"] = usr.Name.ToString();
                    return RedirectToAction("LoggeIn");
                }
                else
                {
                    ModelState.AddModelError("", "Name or Password is wrong.");
                }
            }
            return View();

        }

        public ActionResult LoggeIn()
        {
            if (Session["UserID"] != null)
            {
                return View();

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}