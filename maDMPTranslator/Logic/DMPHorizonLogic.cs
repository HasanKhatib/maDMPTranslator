using maDMPTranslator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPHorizonLogic : IDMPLogic
    {
        public Dictionary<string, string> QuestionsDict = null;
        public Dictionary<string, string> AnswersDict = null;

        public Dictionary<string, string> InitializeAnswersDict()
        {
            AnswersDict["FAIR_DATA"] = "I'm {1}.";
            return AnswersDict;
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            AnswersDict["FAIR_DATA"] = "I'm {1}.";
            return QuestionsDict;
        }
    }
}