using maDMPTranslator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace maDMPTranslator.Controllers
{
    public class DMPController : BaseController
    {
        // GET: DMP
        public ActionResult Index()
        {
            return RedirectToAction("Convert");
        }

        [HttpGet]
        public ActionResult Convert() {
            ShowMessage("Haloo", "Detailssss", false, Models.Utils.MessageType.Fail);
            return View();
        }

        [HttpPost]
        public ActionResult Convert(ConvertDMPViewModel convertDMPViewModel) {

            if (!ModelState.IsValid)
                return View();

            if (convertDMPViewModel != null && convertDMPViewModel.Files.Length > 0 &&
                convertDMPViewModel.Files[0].ContentLength < 0)
                return View();

            string json = string.Empty;
            json = new StreamReader(convertDMPViewModel.Files.First().InputStream)
                .ReadToEnd();
            TempData["jsonContent"] = json;
            return RedirectToAction("Convert");
        }
    }
}