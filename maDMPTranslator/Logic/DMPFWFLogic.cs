using maDMPTranslator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPFWFLogic : IDMPLogic
    {
        public Dictionary<string, string> QuestionsDict = null;
        public Dictionary<string, string> AnswersDict = null;

        public Dictionary<string, string> InitializeAnswersDict()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            throw new NotImplementedException();
        }
    }
}