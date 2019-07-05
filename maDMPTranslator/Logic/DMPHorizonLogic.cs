using maDMPTranslator.Logic.Interfaces;
using maDMPTranslator.Models.RDA_DMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPHorizonLogic : IDMPLogic
    {
        public Dictionary<string, string> QuestionsDict = new Dictionary<string, string>();
        public Dictionary<string, string> HeaderDict = new Dictionary<string, string>();
        public Dictionary<string, List<string>> AnswersDict = new Dictionary<string, List<string>>();


        public Dictionary<string, string> InitializeHeaderDict(Models.RDA_DMP.maDMP maDMP)
        {
            HeaderDict["title"] = maDMP.DMP.Title;
            HeaderDict["contact"] = @"Name: " + maDMP.DMP.Contact.Name + "<br />Mail:" + maDMP.DMP.Contact.Mail + "<br />ID:" + maDMP.DMP.Contact.contact_id?.contact_id;
            HeaderDict["doi"] = maDMP.DMP.dmpID?.contact_id;
            return HeaderDict;
        }

        public Dictionary<string, List<string>> InitializeAnswersDict(Models.RDA_DMP.maDMP maDMP)
        {
            #region data summary
            string dataSummary = "In this experiment, {0}." +
                "<br /> With this purpose, the following datasets are required:" +
                "<br /> {1}." +
                "<br />" +
                "<br /> The information contained is in {2} language formatted as {3}." +
                " About if there is sensitive data, the answer would be {4}. And for personal data, the answer would be {5}. " +
                "This dataset has been issued on: {6}." +
                "<br />";

            AnswersDict["DATA_SUMMARY"] = new List<string>() {
                string.Format(dataSummary,
                //0
                maDMP.DMP.Description,
                string.Join(", ",maDMP.DMP.Dataset.Select(d=>d.Title)),
                string.Join(maDMP.DMP.Language,"ENGLISH"),
                maDMP.DMP.Dataset?.First().Type,
                maDMP.DMP.Dataset.First().Sensitive_data,
                maDMP.DMP.Dataset.First().Personal_data,
                //6
                maDMP.DMP.Dataset?.First().Issued)
            };
            #endregion

            #region FAIR
            string datasetsFAIRInfo = string.Empty;
            for (int counter = 0; counter < maDMP.DMP.Dataset.Count; counter++)
            {
                
                datasetsFAIRInfo += counter + 1 + " - " + maDMP.DMP.Dataset.ElementAt(counter).Title + " has the next keywords: " +
                   "<br/>";


                //CARLOS
                List<string> keywords = maDMP.DMP.Dataset.ElementAt(counter).KeywordsList;
                for (int i = 0; i < keywords.Count; i++)
                {
                    if (i == (keywords.Count - 1))
                    {
                        datasetsFAIRInfo += keywords.ElementAt(i);
                    }
                    else
                    {
                        datasetsFAIRInfo += keywords.ElementAt(i) + ", ";
                    }
                }
                    datasetsFAIRInfo += "<br/>To have a better understanding of the data, the Metadata has been generated using the standard:" +
                    "<br/>" + maDMP.DMP.Dataset.ElementAt(counter).metadata +
                    "<br/>" +
                    "This data is published in type of " + maDMP.DMP.Dataset.ElementAt(counter).Type + "." ;

                //Reusable
                foreach (Distribution dataset in maDMP.DMP.Dataset.ElementAt(counter).distribution)
                {

                    datasetsFAIRInfo += "<br/>" + "The dataset is stored in a repository with following specifications:";
                    datasetsFAIRInfo += "<br/>" + "Repository name: " + dataset.Title;
                    datasetsFAIRInfo += "<br/>" + "The data in format " + dataset.Format + " and size " + dataset.ByteSize + " Bytes.";
                    datasetsFAIRInfo += "<br/>" + "The access is " + dataset.DataAccess + " to the information is using the URL: " + dataset.AccessURL;
                    datasetsFAIRInfo += "<br/>" + "To download this file use the URL: " + dataset.DownloadURL;
                    datasetsFAIRInfo += "<br/>" + "Available until: " + dataset.AvailableTill;
                    //datasetsFAIRInfo += "<br/>" + "The Access is : " + dataset.DataAccess;
                    datasetsFAIRInfo += "<br/>" + "This dataset is distributed under the license: " + string.Join(",", dataset.license.Select(l => l.license_ref));
                    datasetsFAIRInfo += "<br/>";
                }
                datasetsFAIRInfo += "<br/><br/>";
            }

            AnswersDict["FAIR_2"] = new List<string>() {
                datasetsFAIRInfo
            };
            #endregion

            #region 3 allocation
            string allocation = string.Empty;
            for (int counter = 0; counter < maDMP.DMP.Cost.Count; counter++)
            {
                allocation += counter + 1 + "- " + maDMP.DMP.Cost.ElementAt(counter).Title + "." +
                    "<br/>" + maDMP.DMP.Cost.ElementAt(counter).Description + ". The cost for the requirements is " + maDMP.DMP.Cost.ElementAt(counter).CostType;
                //string value = maDMP.DMP.Cost.ElementAt(counter).Value.ToString;
                allocation += "<br/>" + "With a total cost of: " + maDMP.DMP.Cost.ElementAt(counter).Value + " in " + maDMP.DMP.Cost.ElementAt(counter).CostUnit;
            }
            AnswersDict["ALLOCATION_3"] = new List<string>() {
                allocation
                };
            #endregion

            #region 4 security
            string security = string.Empty;
            foreach(Dataset dataset in maDMP.DMP.Dataset)
            {
                foreach(SecurityAndPrivacy securityAndPrivacy in dataset.security_and_privacy)
                {
                    security += securityAndPrivacy.Title + "<br/>" ;
                }
            }
            if (string.IsNullOrEmpty(security))
                security = "There is no information regarding security issues.";
            AnswersDict["SECURITY_4"] = new List<string>() {
                security
            };
            #endregion

            //1 dmp_ethicalIssuesExist
            //2 dmp_ethicalIssuesDescription
            string ethicalInfo = string.Empty;
            ethicalInfo += maDMP.DMP.Ethical_issues_description;
            AnswersDict["ETHICAL_5"] = new List<string>() {
               ethicalInfo
            };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no other aspects to consider related to this experiment."};

            return AnswersDict;
        }


        public Dictionary<string, string> InitializeQuestionsDict()
        {
            QuestionsDict["DATA_SUMMARY_1"] = "1 Data Summary";

            QuestionsDict["FAIR_2"] = "2 Making data FAIR";

            QuestionsDict["ALLOCATION_3"] = "3 Allocation of resources";

            QuestionsDict["SECURITY_4"] = "4 Data Security";

            QuestionsDict["ETHICAL_5"] = "5 Ethical aspects";

            QuestionsDict["OTHER_6"] = "6 Other issues";

            return QuestionsDict;
        }
    }
}