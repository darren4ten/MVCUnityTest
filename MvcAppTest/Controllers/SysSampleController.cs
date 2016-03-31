using App.BLL;
using App.Common;
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
            GridPager pager = new GridPager();
            pager.rows = 5;
            pager.page=1;
            var data = bll.GetList(pager);
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (bll.Delete(id))
            {
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(string id)
        {
            var data = bll.GetById(id);
            return View(data);
        }

        [HttpPost]
        public JsonResult Edit(SysSampleModel model)
        {
            if (bll.Edit(model))
            {
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Create(SysSampleModel model)
        {
            if (bll.Create(model))
            {
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }
          
        }

        [HttpPost]
        public JsonResult GetList(GridPager pager)
        {
            var data = bll.GetList(pager);
            var jsonData =
                new
                {
                    total = pager.totalRows,
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
                    ).OrderBy(p=>p.Id)
                };
            return Json(jsonData,JsonRequestBehavior.AllowGet);
        }

    }
}
