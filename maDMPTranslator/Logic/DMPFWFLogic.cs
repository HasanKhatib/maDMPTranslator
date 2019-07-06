using maDMPTranslator.Logic.Interfaces;
using maDMPTranslator.Models.RDA_DMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPFWFLogic : IDMPLogic
    {
        public Dictionary<string, string> QuestionsDict = null;
        public Dictionary<string, string> HeaderDict = new Dictionary<string, string>();
        public Dictionary<string, List<string>> AnswersDict = null;

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
                "<br /> The information of the DMP is in {2} language." +
                "<br /> The DMP has been created on: {3} and its last modification has been on {4}" +
                //"About if there is sensitive data, the answer would be {4}. And for personal data, the answer would be {5}. " +
                //"This dataset has been issued on: {6}." +
                "<br />";

            AnswersDict["data_characteristics"] = new List<string>() {
                string.Format(dataSummary,
                //0
                maDMP.DMP.Description,
                string.Join(", ",maDMP.DMP.Dataset.Select(d=>d.Title)),
                string.Join(maDMP.DMP.Language,"ENGLISH"),
                
                //CARLOS
                maDMP.DMP.Created,
                maDMP.DMP.Modified)
            };
            //maDMP.DMP.Dataset?.First().Type,
            //maDMP.DMP.Dataset.First().Sensitive_data,
            //maDMP.DMP.Dataset.First().Personal_data,
            //6
            //maDMP.DMP.Dataset?.First().Issued)
            //};
            #endregion

            #region FAIR
            string datasetsFAIRInfo = string.Empty;
            string datasetsSTORAGE = string.Empty;

            for (int counter = 0; counter < maDMP.DMP.Dataset.Count; counter++)
            {



                datasetsFAIRInfo += counter + 1 + " - " + maDMP.DMP.Dataset.ElementAt(counter).Title;

                datasetsFAIRInfo += "<br/>" + "Issued on: " + maDMP.DMP.Dataset.ElementAt(counter).Issued;
                datasetsFAIRInfo += "<br/>" + "Keywords: ";


                //CARLOS
                List<string> keywords = maDMP.DMP.Dataset.ElementAt(counter).KeywordsList;
                for (int i = 0; i < keywords.Count; i++)
                {
                    if (i == (keywords.Count - 1))
                    {
                        datasetsFAIRInfo += keywords.ElementAt(i) + ".";
                    }
                    else
                    {
                        datasetsFAIRInfo += keywords.ElementAt(i) + ", ";
                    }
                }
                datasetsFAIRInfo += "<br/>The metadata has been generated using the standard: " + maDMP.DMP.Dataset.ElementAt(counter).metadata;

                datasetsFAIRInfo += "<br/>" + "This data is published in type of " + maDMP.DMP.Dataset.ElementAt(counter).Type + ".";
                datasetsFAIRInfo += "<br/>" + "The information contained is written in " + string.Join(maDMP.DMP.Dataset.ElementAt(counter).Language, "English") + " Languague.";
                datasetsFAIRInfo += "<br/>" + "There are " + maDMP.DMP.Dataset.ElementAt(counter).Sensitive_data + " sensitive data either " + maDMP.DMP.Dataset.ElementAt(counter).Personal_data + " personal data related to this dataset.";
                datasetsFAIRInfo += "<br/>";

                //Storage

                datasetsSTORAGE += counter + 1 + " - " + maDMP.DMP.Dataset.ElementAt(counter).Title;

                foreach (Distribution dataset in maDMP.DMP.Dataset.ElementAt(counter).distribution)
                {

                    datasetsSTORAGE += "<br/>" + "The dataset is stored in a repository with following specifications:";
                    datasetsSTORAGE += "<br/>" + "Repository name: " + dataset.Title;
                    datasetsSTORAGE += "<br/>" + "The data in format " + dataset.Format + " and size " + dataset.ByteSize + " Bytes.";
                    datasetsSTORAGE += "<br/>" + "The access is " + dataset.DataAccess + " to the information using the URL: " + dataset.AccessURL;
                    datasetsSTORAGE += "<br/>" + "To download this file use the URL: " + dataset.DownloadURL;
                    datasetsSTORAGE += "<br/>" + "Available until: " + dataset.AvailableTill;
                    //datasetsSTORAGE += "<br/>" + "The Access is : " + dataset.DataAccess;
                    datasetsSTORAGE += "<br/>" + "This dataset is distributed under the license: " + string.Join(",", dataset.license.Select(l => l.license_ref));
                    datasetsSTORAGE += "<br/>";
                }
                datasetsSTORAGE += "<br/>" + "There is no information regarding security issues." + "<br/>";
            }

            AnswersDict["Doc_Metadata"] = new List<string>() {
                datasetsFAIRInfo
            };

            AnswersDict["Availability_Storage"] = new List<string>() {
                datasetsSTORAGE
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
            foreach (Dataset dataset in maDMP.DMP.Dataset)
            {
                foreach (SecurityAndPrivacy securityAndPrivacy in dataset.security_and_privacy)
                {
                    security += securityAndPrivacy.Title + "<br/>";
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


            AnswersDict["Legal_Ethical"] = new List<string>() {
               ethicalInfo
            };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no other aspects to consider related to this experiment." };

            return AnswersDict;
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            QuestionsDict["data_characteristics"] = "I Data_Characteristics";

            QuestionsDict["Doc_Metadata"] = "II Documentation and Metadata";

            QuestionsDict["Availability_Storage"] = "III Data Availability and Storage";

            QuestionsDict["Legal_Ethical"] = "IV Legal and Ethical Aspects";

            return QuestionsDict;
        }
    }
}