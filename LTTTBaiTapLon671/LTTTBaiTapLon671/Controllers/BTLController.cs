using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTTTBaiTapLon671.Controllers
{
    public class BTLController : Controller
    {
        // GET: BTL
        public ActionResult Index(string TenDangNhap, string MatKhau)
        {
            ViewBag.Message = TenDangNhap + "" + MatKhau;
            return View();
        }
    }
}