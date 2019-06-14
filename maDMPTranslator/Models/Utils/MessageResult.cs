using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.Utils
{
    public class MessageResult<T>
    {
        public bool Success { get; set; }
        public MessageType Status { get; set; }
        public string Message { get; set; }
        public string DetailedMessage { get; set; }
        public T ReturnedValue { get; set; }

        public MessageResult()
        {
            Status = MessageType.Success;

        }
        public MessageResult(string message, MessageType status, bool success)
        {
            this.Message = message;
            this.Status = status;
            this.Success = success;
        }

        public MessageResult(Exception ex)
        {
            this.Success = false;
            this.Status = MessageType.Fail;
            this.Message = "An unexpected error occurred while executing the action";
            Exception exception = ex;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }
            this.DetailedMessage = exception.Message;
        }

        public MessageResult ToResult()
        {
            return new MessageResult { Message = this.Message, DetailedMessage = this.DetailedMessage, ReturnedValue = this.ReturnedValue, Status = this.Status, Success = this.Success };
        }

        public MessageResult<T> PrepareActionResult(string message, MessageType status, bool success)
        {
            this.Message = message;
            this.Status = status;
            this.Success = success;
            return this;
        }

        public MessageResult<T> PrepareFailedActionResultWithDetails(string messageHeader, string messageDetails)
        {
            this.Message = messageHeader;
            this.DetailedMessage = messageDetails;
            this.Status = MessageType.Fail;
            this.Success = false;
            return this;
        }

        public MessageResult<T> PrepareFailedActionResult(string message)
        {
            this.Message = message;
            this.Status = MessageType.Fail;
            this.Success = false;
            return this;
        }
    }

    public class MessageResult
    {
        private Exception ex;

        public MessageResult()
        {
            this.Status = MessageType.Success;
        }

        public MessageResult(string message, MessageType status, bool success)
        {
            this.Message = message;
            this.Status = status;
            this.Success = success;
        }

        public MessageResult(string message, MessageType status, bool success, string detailedMessage)
        {
            this.Message = message;
            this.Status = status;
            this.Success = success;
            this.DetailedMessage = detailedMessage;
        }

        public MessageResult(Exception ex)
        {
            this.ex = ex;
        }

        public bool Success { get; set; }
        public MessageType Status { get; set; }
        public string Message { get; set; }
        public dynamic ReturnedValue { get; set; }
        public string DetailedMessage { get; set; }
        public string Warnings { get; set; }

        public MessageResult PrepareActionResult(string message, MessageType status, bool success)
        {
            this.Message = message;
            this.Status = status;
            this.Success = success;
            return this;
        }
        public MessageResult PrepareFailedActionResult(string message)
        {
            this.Message = message;
            this.Status = MessageType.Fail;
            this.Success = false;
            return this;
        }

        public MessageResult PrepareFailedActionResultWithDetails(string messageHeader, string messageDetails)
        {
            this.Message = messageHeader;
            this.DetailedMessage = messageDetails;
            this.Status = MessageType.Fail;
            this.Success = false;
            return this;
        }
    }

    public enum MessageType
    {
        Success,
        Fail,
        Information,
        Warning
    }
}
