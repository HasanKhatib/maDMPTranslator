using maDMPTranslator.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maDMPTranslator.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Used to show a message in the View side.
        /// </summary>
        /// <param name="MessageHeader"></param>
        /// <param name="MessageDetails"></param>
        /// <param name="Type"></param>
        protected void ShowMessage(string MessageHeader, string MessageDetails, bool isSuccess, MessageType messageType)
        {
            if (isSuccess)
            {
                if (string.IsNullOrEmpty(MessageHeader))
                    MessageHeader = "Successfull";
            }
            TempData["ViewMessage"] = new MessageResult() { Message = MessageHeader, DetailedMessage = MessageDetails, Success = isSuccess, Status = messageType};
        }

        protected void ShowMessage(MessageResult msg)
        {
            if (msg.Success)
            {
                if (string.IsNullOrEmpty(msg.Message))
                    msg.Message = "Successfull";
            }
            TempData["ViewMessage"] = new MessageResult() {
                Message = msg.Message,
                DetailedMessage = msg.DetailedMessage,
                Success = msg.Success,
                Status = msg.Status
            };
        }
    }
}