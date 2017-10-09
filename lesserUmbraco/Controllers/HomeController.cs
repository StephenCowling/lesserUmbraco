using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace lesserUmbraco.Controllers
{
    public class HomeController : SurfaceController
    {

        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Home/";

        public ActionResult RenderFeatured()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Featured.cshtml");
        }
    }
}