using maDMPTranslator.Models.RDA_DMP;
using maDMPTranslator.Models.Utils;
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
            if(!result.Success)
            {
                ShowMessage(result.Message,result.DetailedMessage,result.Success, result.Status);
                return View();
            }

            TempData["jsonContent"] = json;
            TempData["DMPTemplate"] = convertDMPViewModel.Template;
            TempData["DMPAnswers"] = DMPLogic.GetAnswers(result.ReturnedValue).ReturnedValue;
            TempData["DMPQuestions"] = DMPLogic.GetQuestions().ReturnedValue;

            if (result.Success)
                TempData["dmpResult"] = result.ReturnedValue;
            else
                ShowMessage(result.Message, result.DetailedMessage, result.Success, result.Status);
            var dataObj = new DMPTemplatePDF()
            {
                HeaderDict = DMPLogic.GetHeader(result.ReturnedValue).ReturnedValue,
                AnswersDict = DMPLogic.GetAnswers(result.ReturnedValue).ReturnedValue,
                QuestionsDict = DMPLogic.GetQuestions().ReturnedValue
            };
            if (convertDMPViewModel.Template.ToLower().StartsWith("h"))
                return new Rotativa.ViewAsPdf("HorizonDMP", dataObj) { FileName = "DMP_Horizon.pdf" };
            else
                return new Rotativa.ViewAsPdf("FWfDMP", dataObj) { FileName = "DMP_FWF.pdf" };

        }

        public ActionResult HorizonDMP(DMPTemplatePDF dataModel)
        {
            if (dataModel == null || dataModel.AnswersDict == null || dataModel.HeaderDict == null || dataModel.QuestionsDict == null)
            {
                ShowMessage("There is no data", 
                    "You didn't follow the standard way to provide data to this page. <br/> <a href=\"http://localhost/maDMPTranslator/DMP/convert\">Click here to go to convert page</a>",
                    false, MessageType.Warning);
                return View(dataModel);
            }
            return View(dataModel);
        }

        public ActionResult FWfDMP(DMPTemplatePDF dataModel)
        {
            return View(dataModel);
        }
    }
}