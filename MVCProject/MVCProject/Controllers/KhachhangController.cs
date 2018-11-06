using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class KhachhangController : Controller
    {
        // GET: Khachhang
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(KhachHangVM model)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
            return Json(new { status = true,msgg = "thanh cong" });
        }
    }
}