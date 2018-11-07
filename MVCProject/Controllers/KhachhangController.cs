using MVCBusiness1.DataContext;
using MVCBusiness1.IRepository;
using MVCBusiness1.Repository;
using MVCProject.Models;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class KhachhangController : Controller
    {
        IKhachHangRepository kh = new KhachHangRepository();
        // GET: Khachhang
        public ActionResult Index()
        {
            KhachHangVM model = new KhachHangVM();
            model.lst = kh.getLst();
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(KhachHangVM model)
        {
            try
            {
                KhachHang data = new KhachHang();
                data.Id = Convert.ToInt32(model.input.user_cd);
                data.username = model.input.user_name;
                data.password = model.input.pass_word;
                data.adress = model.input.adress;
                data.sex = model.input.sex;
                data.mobile = model.input.mobile;
                data.update_date = DateTime.Now;
                var result = kh.Add(data);
                if (result)
                    return Json(new { status = true });
                else
                    return Json(new { status = false, msg = "Thêm thất bại" });
            }
            catch(Exception ex)
            {
                return Json(new { status = false, msg = "Thêm thất bại" });
            }
            
            
            //return RedirectToAction("GetLst", "KhachHang");
            //return Json(new { status = true,msgg = "thanh cong" });
        }


        public static string RenderRazorViewToString(ControllerContext controllerContext, string viewName, object model)
        {
            controllerContext.Controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
                var viewContext = new ViewContext(controllerContext, viewResult.View, controllerContext.Controller.ViewData, controllerContext.Controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}