using maDMPTranslator.Models.Utils;
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

        public DMPLogic()
        {
        }

        public DMPLogic(string Template)
        {
            if (Template.StartsWith("Horizon"))
                _DMPLogicInstance = new DMPHorizonLogic();
            else
                _DMPLogicInstance = new DMPFWFLogic();
        }

        public MessageResult<Models.RDA_DMP.maDMP> ConvertmaDMPtoDMP(string maDMP)
        {
            MessageResult<Models.RDA_DMP.maDMP> result = new MessageResult<Models.RDA_DMP.maDMP>
            {
                Success = false,
                Status = MessageType.Fail
            };
            try
            {
                result.ReturnedValue = JsonConvert.DeserializeObject<Models.RDA_DMP.maDMP>(maDMP);
            }
            catch (Exception ex)
            {
                result.Message = "Error!";
                result.DetailedMessage = ex.Message;
                return result;
            }
            result.Message = "Done!";
            result.Success = true;
            result.Status = MessageType.Success;
            return result;
        }
    }
}