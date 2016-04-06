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
    public class HomeController : Controller
    {
        [Dependency]
        public IHomeBLL homeBLL { get; set; }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            AccountModel account = new AccountModel();
            account.Id = "admin";
            account.TrueName = "Darren Teng";
            Session["Account"] = account;
            //int a = 1;
            //int b = 99 / (a - 1);
            return View();
        }

        /// <summary>
        /// 获取导航菜单
        /// </summary>
        /// <param name="id">所属</param>
        /// <returns>树</returns>
        public JsonResult GetTree(string id)
        {

            List<SysModule> menus = homeBLL.GetMenuByPersonId(id);
            var jsonData = (
                    from m in menus
                    select new
                    {
                        id = m.Id,
                        text = m.Name,
                        value = m.Url,
                        showcheck = false,
                        complete = false,
                        isexpand = false,
                        checkstate = 0,
                        hasChildren = m.IsLast ? false : true,
                        Icon = m.Iconic
                    }
                ).ToArray();
            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }
    }
}
