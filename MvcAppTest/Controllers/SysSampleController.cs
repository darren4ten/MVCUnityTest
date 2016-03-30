using App.BLL;
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

        public ActionResult Index()
        {
            var data = new SysSampleBLL().GetList("");
            return View(data);
        }

    }
}
