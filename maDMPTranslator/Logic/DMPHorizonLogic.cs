using maDMPTranslator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic
{
    public class DMPHorizonLogic : IDMPLogic
    {
        public Dictionary<string, string> QuestionsDict = new Dictionary<string, string>();
        public Dictionary<string, List<string>> AnswersDict = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> InitializeAnswersDict(Models.RDA_DMP.maDMP maDMP)
        {
            //1: project description
            //2: datasets titles (joined)
            //3: language
            //4: dataset type
            //5 dataset_description
            //6 dataset_sensitive_data
            //7 dataset_personal_data
            //8 preservation_statement
            //9 dataset_issued
            //10 dataset_datasetID_type
            //11 dataset_datasetID
            //12 dataset_distribution_byteSize
            //13 dmp_description
            string dataSummary = "In this experiment, {0}." +
                "\n With this purpose, the following datasets are required:" +
                "\n {1}." +
                "\n The information contained is in {2} language formatted as {3} about {4}." +
                " It does {5} contain sensitive data as well as {6} regarding personal data. " +
                "{7}.\n This dataset has been issued on: {8}." +
                "\n The data file has its own Digital Identification {9} which can be accessed through the link " +
                "{10}, its total size is of {11} bytes.\n";

            AnswersDict["DATA_SUMMARY"] = new List<string>() {
                string.Format(dataSummary,maDMP.DMP.Description,"","","","","","","","","","",""),
                ""
            };



            AnswersDict["FAIR_2"] = new List<string>() {
                "In order to align the experiment with the basics principles of FAIR the following information has been also attached to this DMP:\n" +
                "FAIR" +
                "FOR EACH DS IN DATASET ["+
                "i. {dataset_title}\n" +
                "Keywords: FOR EACH KW IN keyword {dataset_keyword}\n" +
                "To have a better understanding of the data, the following Metadata has been generated: {dataset_metadata_description}\n" +
                "The convenction used to manage the data are: {dataset_data_quality_assurance}\n" +
                "This Metadata is written in {dataset_metadata_languague} Language from the {dataset_metadata_identifier_type} which can be found in {dataset_metadata_identifier_id}.\n" +
                "The data in format {dataset_distribution_format} and size {dataset_distribution_size} bytes\n" +
                "The Access to the data is {dataset_distribution_dataAccess} by the URL: {dataset_distribution_accessURL} \n" +
                "To Download it, use the link: {dataset_distribution_downloadURL} \n" +
                "Available until: {dataset_distribution_availableTill}\n" +
                "This dataset is under the license {dataset_distribution_license_license_ref} starting on {dataset_distribution_license_startDate}.\n" +
                "In addition, the dataset is stored in a Repository with the following specifications: \n" +
                "Name: {dataset_distribution_host_title}.\n" +
                "Located in: {dataset_distribution_host_geoLocation}.\n" +
                "The availability is {dataset_distribution_host_availability}%.\n" +
                "This is repository {dataset_distribution_host_description}. With a technology base on {dataset_distribution_host_storageType}, {dataset_distribution_host_supportsVersioning} regarding versioning support.\n" +
                "The PID System is: {dataset_distribution_host_pidSystem}.\n" +
                "Certified with: {dataset_distribution_host_certifiedWith}.\n" +
                "The Backup process consists on {dataset_distribution_host_backupType}; the tasks run regularly with a frequency of {dataset_distribution_host_backupFrequancy}."+
                "]"+

                "\n Technical Resoruces" +
                "\n There are technical resources identified with {technicalResource_TypedIdentifier_ref} with the {technicalResource_TypedIdentifier_Type} code {technicalResource_TypedIdentifier_identifier}."
            };

            AnswersDict["ALLOCATION_3"] = new List<string>() {
                "Allocation of resources" +
                "FOR EACH C IN COST [" +
                "\n The following resources are involved in the DMP:" +
                "\n {dmp_cost_title}" +
                "\n Type of cost: {dmp_cost_costType}" +
                "\n With a total cost of: {dmp_cost_costValue} in {dmp_cost_costUnit}." +
                "\n The specific purposes are {dmp_cost_description}",
                "]",
                "answer {1}, {2}" };

            AnswersDict["SECURITY_4"] = new List<string>() {
                "Data Security" +
                "FOR EACH SA IN SECURITYANDPRIVACY" +
                "\n The security {dmp_securityAndPrivacy_title}" +
                "\n {dmp_securityAndPrivacy_description}",
                ""};

            //1 dmp_ethicalIssuesExist
            //2 dmp_ethicalIssuesDescription
            AnswersDict["ETHICAL_5"] = new List<string>() {
                "Ethical issues related with the data are involved: {1}" +
                "\n {2}" +
                "\n Find out more in: {dmp_ethicalIssuesReport}",
                ""
            };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no Other aspects related.", "answer {1}, {2}" };

            return AnswersDict;
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            QuestionsDict["DATA_SUMMARY_1"] = "1 Data Summary";

            QuestionsDict["FAIR_2"] = "2.1 Making data FAIR";

            QuestionsDict["ALLOCATION_3"] = "3 Allocation of resources";

            QuestionsDict["SECURITY_4"] = "4 Data Security";

            QuestionsDict["ETHICAL_5"] = "5 Ethical aspects";

            QuestionsDict["OTHER_6"] = "6 Other issues";

            return QuestionsDict;
        }
    }
}