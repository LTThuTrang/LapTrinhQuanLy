using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTTTBaiThucHanh671.Models;
using LTTTBaiThucHanh671.Models.Process;

namespace LTTTBaiThucHanh671.Controllers
{
    public class DemoController : Controller
    {
        StringProcess strPro = new StringProcess();
        // GET: Demo
        public ActionResult Demo()
        {
            string newID = strPro.AutoGenerateID("","");
            ViewBag.id = newID;
            return View();
        }

        [HttpPost] 
        public ActionResult Demo(Student    std)
        {
            ViewBag.thongbao = " Hello " + std.StudnetID + "-" + std.StudnetName;
            return View();
        }
    }
}