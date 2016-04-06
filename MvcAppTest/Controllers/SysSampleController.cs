using App.BLL;
using App.Common;
using App.IBLL;
using App.Models;
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
        public ISysLogBLL logBLL { get; set; }
        [Dependency]
        public ISysSampleBLL bll { get; set; }
        public ActionResult Index()
        {
            GridPager pager = new GridPager();
            pager.rows = 5;
            pager.page = 1;
            var data = bll.GetList(pager);
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        protected void WriteLog(string id, string msg, string module, string result)
        {
            object s = Session["Account"];
            AccountModel account = new AccountModel();
            if (s != null)
            {
                account = s as AccountModel;
            }

            logBLL.Create(new SysLog()
            {
                Id = id,
                Message = msg,
                Module = module,
                Operator = account.TrueName,
                Result = result,
                CreateTime = DateTime.Now
            });
        }

        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (bll.Delete(id))
            {
                WriteLog(id, string.Format("Delete sample with id {0} by user", id), "Delete Sample", "Success");
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                WriteLog(id, string.Format("Delete sample with id {0} by user", id), "Delete Sample", "Failed");
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
                WriteLog(model.Id, string.Format("Edit sample with id {0} by user", model.Id), "Edit Sample", "Success");
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                WriteLog(model.Id, string.Format("Edit sample with id {0} by user", model.Id), "Edit Sample", "Failed");
                return Json(0, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Create(SysSampleModel model)
        {

            if (bll.Create(model))
            {
                WriteLog(model.Id, string.Format("Create sample with id {0} by user", model.Id), "Edit Sample", "Success");
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                WriteLog(model.Id, string.Format("Create sample with id {0} by user", model.Id), "Edit Sample", "Failed");
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
                      new SysSampleModel
                      {
                          Id = p.Id,
                          Age = p.Age,
                          Bir = p.Bir,
                          Name = p.Name,
                          Note = p.Note,
                          Photo = p.Photo,
                          CreateTime = p.CreateTime
                      }
                    ).OrderBy(p => p.Id)
                };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

    }
}
