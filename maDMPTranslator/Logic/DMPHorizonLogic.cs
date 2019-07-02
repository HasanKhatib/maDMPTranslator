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
            //0: project description
            //1: datasets titles (joined)
            //2: language
            //3: dataset type
            //4 dataset_description
            //5 dataset_sensitive_data
            //6 dataset_personal_data
            //7 preservation_statement
            //8 dataset_issued
            //9 dataset_datasetID_type
            //10 dataset_datasetID
            //11 dataset_distribution_byteSize

            string dataSummary = "In this experiment, {0}." +
                "\n With this purpose, the following datasets are generated:" +
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


            //1: dataset_keyword
            //2: dataset_metadata_description
            //3: dataset_data_quality_assurance
            //4: dataset_metadata_languague
            //5: dataset_metadata_identifier_type
            //6: dataset_metadata_identifier_id
            //7: dataset_distribution_format
            //8: dataset_distribution_size
            //9: dataset_distribution_dataAccess
            //10: dataset_distribution_accessURL
            //11: dataset_distribution_downloadURL
            //12: dataset_distribution_availableTill
            //13: dataset_distribution_license_license_ref
            //14: dataset_distribution_license_startDate
            //15: dataset_distribution_host_title
            //16: dataset_distribution_host_geoLocation
            //17: dataset_distribution_host_availability
            //18: dataset_distribution_host_description
            //19: dataset_distribution_host_storageType
            //20: dataset_distribution_host_supportsVersioning
            //21: dataset_distribution_host_pidSystem
            //22: dataset_distribution_host_certifiedWith
            //23: dataset_distribution_host_backupType
            //24: dataset_distribution_host_backupFrequancy
            //25: technicalResource_TypedIdentifier_ref
            //26: technicalResource_TypedIdentifier_Type
            //27: technicalResource_TypedIdentifier_identifier

                                          
            AnswersDict["FAIR_2"] = new List<string>() {
                "In order to align the experiment with the basics principles of FAIR the following information has been also attached to this DMP:\n" +
                "FAIR" +
                "FOR EACH DS IN DATASET ["+
                "i. {dataset_title}\n" +
                "Keywords: FOR EACH KW IN keyword {1}\n" +
                "To have a better understanding of the data, the following Metadata has been generated: {2}\n" +
                "The convenction used to manage the data are: {3}\n" +
                "This Metadata is written in {4} Language from the {5} framework, which can be found in {6}.\n" +
                "The data is stored in format {7} with a size of {8} bytes\n" +
                "The Access to the data is {9} by the URL: {10} \n" +
                "To Download it, use the link: {11} \n" +
                "Available until: {12}\n" +
                "This dataset is under the license {13} starting on {14}.\n" +
                "In addition, the dataset is stored in a Repository with the following specifications: \n" +
                "Name: {15}.\n" +
                "Located in: {16}.\n" +
                "The availability is {17}%.\n" +
                "This is repository {18}. With a technology base on {19}, {20} regarding versioning support.\n" +
                "The PID System is: {21}.\n" +
                "Certified with: {22}.\n" +
                "The Backup process consists on {23}; the tasks run regularly with a frequency of {24}."+
                "]"+

                "\n Technical Resoruces" +
                "\n There are technical resources identified with {25} with the {26} code {27}."
            };

            //1: dmp_cost_title
            //2: dmp_cost_costType
            //3: dmp_cost_costValue
            //4: dmp_cost_costUnit
            //5: dmp_cost_description

            AnswersDict["ALLOCATION_3"] = new List<string>() {
                "Allocation of resources" +
                "FOR EACH C IN COST [" +
                "\n The following resources are involved in the DMP:" +
                "\n {1}" +
                "\n Type of cost: {2}" +
                "\n With a total cost of: {3} in the unit of {4}." +
                "\n The specific purposes are {5}",
                "]",
                "answer {1}, {2}" };

            //1: dmp_securityAndPrivacy_title
            //2: dmp_securityAndPrivacy_description
            //3:
            //4:
            //5:


            AnswersDict["SECURITY_4"] = new List<string>() {
                "Data Security" +
                "FOR EACH SA IN SECURITYANDPRIVACY" +
                "\n Security aspects regarding {1} are involved." +
                "\n Which consists in {2}",
                ""};

            //1: dmp_ethicalIssuesExist
            //2: dmp_ethicalIssuesDescription
            //3: dmp_ethicalIssuesReport

            AnswersDict["ETHICAL_5"] = new List<string>() {
                "Ethical issues related with the data are involved: {1}" +
                "\n {2}" +
                "\n Find out more in: {3}",
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