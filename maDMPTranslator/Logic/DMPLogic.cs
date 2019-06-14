using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPLogic
    {
        private Interfaces.IDMPLogic _DMPLogicInstance = null;
        public DMPLogic(string Template)
        {
            if (Template.StartsWith("Horizon"))
                _DMPLogicInstance = new DMPHorizonLogic();
            else
                _DMPLogicInstance = new DMPFWFLogic();
        }

        public Models.RDA_DMP.DMP ConvertmaDMPtoDMP(string maDMP)
        {
            
            var result = JsonConvert.DeserializeObject<Models.RDA_DMP.DMP>(maDMP);


            return null;
        }
    }
}