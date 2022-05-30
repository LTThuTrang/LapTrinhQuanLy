using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LTTTBaiThucHanh671.Models;

namespace LTTTBaiThucHanh671.Controllers
{
    public class AccountController : Controller
    {
        Encrytion encry = new Encrytion();
        ThuchanhDbcontext db = new ThuchanhDbcontext();

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                //mã hóa mật khẩu trước khi lưu vào database
                acc.PassWord = encry.PasswordEncrytion(acc.PassWord);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if(ModelState.IsValid)
            {
                string encrytionpass = (string)encry.PasswordEncrytion(acc.PassWord);
                var model = db.Accounts.Where(m => m.UserName == acc.UserName && m.PassWord == encrytionpass).ToList().Count();
                //thông tin đăng nhập chính xác
                if(model == 1)
                {

                    FormsAuthentication.SetAuthCookie(acc.UserName, true);


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}