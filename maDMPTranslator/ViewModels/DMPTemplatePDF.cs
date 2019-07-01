using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.ViewModels
{
    public class DMPTemplatePDF
    {
        public Dictionary<string, List<string>> AnswersDict { set; get; }
        public Dictionary<string, string> QuestionsDict { set; get; }

    }
}