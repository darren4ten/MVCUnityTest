using App.BLL;
using App.IBLL;
using App.Models.Sys;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppTest.Controllers
{
    public class SysSampleController : Controller
    {
        //
        // GET: /SysSample/
        [Dependency]
        public ISysSampleBLL bll { get; set; }
        public ActionResult Index()
        {
            var data = bll.GetList("");
            return View(data);
        }

        public JsonResult GetList()
        {
            var data = bll.GetList("");
            var jsonData =
                new
                {
                    total = data.Count,
                    rows = data.Select(p =>
                      new SysSampleModel{
                        Id=p.Id,
                        Age=p.Age,
                        Bir=p.Bir,
                        Name=p.Name,
                        Note=p.Note,
                        Photo=p.Photo,
                        CreateTime=p.CreateTime
                      }
                    )
                };
            return Json(jsonData,JsonRequestBehavior.AllowGet);
        }

    }
}
