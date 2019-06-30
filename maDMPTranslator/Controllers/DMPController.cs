﻿using maDMPTranslator.ViewModels;
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
        private static Logic.DMPLogic DMPLogic = new Logic.DMPLogic();
        // GET: DMP
        public ActionResult Index()
        {
            return RedirectToAction("Convert");
        }

        [HttpGet]
        public ActionResult Convert()
        {
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
            //json = Regex.Replace(
            //    json,
            //    @"\t|\n|\r|\\",
            //    "");
            TempData["jsonContent"] = json;

            var result = DMPLogic.ConvertmaDMPtoDMP(json);
            if (result.Success)
                TempData["dmpResult"] = result.ReturnedValue;
            else
                ShowMessage(result.Message, result.DetailedMessage, result.Success, result.Status);
            return RedirectToAction("Convert");
        }
    }
}