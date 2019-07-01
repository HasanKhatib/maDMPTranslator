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
        private static Logic.DMPLogic DMPLogic = null;
        // GET: DMP
        public ActionResult Index()
        {
            return RedirectToAction("Convert");
        }

        [HttpGet]
        public ActionResult Convert()
        {
            if (TempData["dmpResult"] != null && !string.IsNullOrEmpty(TempData["dmpResult"].ToString()))
                return View(new ConvertDMPViewModel() { maDMP = (Models.RDA_DMP.maDMP)TempData["dmpResult"] });
            else
                return View();

        }

        [HttpPost]
        public ActionResult Convert(ConvertDMPViewModel convertDMPViewModel)
        {

            if (!ModelState.IsValid)
                return View();

            if (convertDMPViewModel != null && convertDMPViewModel.Files.Length > 0 &&
                convertDMPViewModel.Files[0].ContentLength < 0)
                return View();

            string json = string.Empty;

            json = new StreamReader(convertDMPViewModel.Files.First().InputStream)
                .ReadToEnd();
            DMPLogic = new Logic.DMPLogic(convertDMPViewModel.Template);
            var result = DMPLogic.ConvertmaDMPtoDMP(json);

            TempData["jsonContent"] = json;
            TempData["DMPTemplate"] = convertDMPViewModel.Template;
            TempData["DMPAnswers"] = DMPLogic.GetAnswers(result.ReturnedValue).ReturnedValue;
            TempData["DMPQuestions"] = DMPLogic.GetQuestions().ReturnedValue;

            var dmpData = new DMPTemplatePDF()
            {
                AnswersDict = (Dictionary<string, List<string>>)TempData["DMPAnswers"],
                QuestionsDict = (Dictionary<string, string>)TempData["DMPQuestions"]
            };

            if (result.Success)
            {
                var report = new Rotativa.ViewAsPdf("HorizonDMP", new { data = dmpData });
                TempData["dmpResult"] = result.ReturnedValue;
                return report;
            }
            else { 
                ShowMessage(result.Message, result.DetailedMessage, result.Success, result.Status);
                return View();
            }
            //return RedirectToAction("Convert");
        }

        public ActionResult HorizonDMP(DMPTemplatePDF data)
        {
            return View(data);
        }
    }
}