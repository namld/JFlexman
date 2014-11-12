using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JFlexman.Areas.JFlexman.Controllers
{
    public class FormBuilderController : Controller
    {
        //
        // GET: /JFlexman/FormBuilder/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSubLevels(string uniqueDataID, int? user)
        {
            List<object> subRows = new List<object>();
            subRows.Add(new { p1 = 1, p2 = "p2s", p3 = new {aa = "toi ko can ai"}});
            return Json(new { SubRows = subRows, bien2 = 999});
        }

    }
}
