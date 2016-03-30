using App.BLL;
using App.IBLL;
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

    }
}
