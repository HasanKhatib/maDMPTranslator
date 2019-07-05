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
        public Dictionary<string, List<string>> AnswersDict = null;

        public Dictionary<string, string> InitializeHeaderDict(Models.RDA_DMP.maDMP maDMP)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, List<string>> InitializeAnswersDict(Models.RDA_DMP.maDMP maDMP)
        {
            //1: project description
            //2: dataset.size
            //3: datasets titles (joined)
            //4: language
            //5: dataset type
            //6: dataset_description
            //7: dataset_sensitive_data
            //8: dataset_personal_data
            //9: preservation_statement
            //10: dataset_issued
            //11: dataset_datasetID_type
            //12: dataset_datasetID
            //13: dataset_distribution_byteSize
            //14: dmp_description
            //15: dmp_created
            //16: dmp_modified
            AnswersDict["DATA_OFFICER"] = new List<string>() {"The responsible for this Data Management Plan (DMP) is: {dmp_contact_name}" +
                                                                "\n email: {dmp_contact_mbox}" +
                                                                "\n with ID from {dmp_contact_contactID_identifierType}" +
                                                                "\n ({dmp_contact_contactID_identifier})" +
                                                                "The staff involved in the experiment is integrated by"+
                                                                "FOR EACH STAFF IN DMSTAFF [" +
                                                                "\n The responsale for {dmp_dmStaff_contributor_type} is: {dmp_contact_name}" +
                                                                "\n email: {dmp_contact_mbox}" +
                                                                "\n with ID from {dmp_contact_contactID_identifierType}" +
                                                                "\n ({dmp_contact_contactID_identifier})",

                                                                "DONE YYY Answer2 {0}"


                };


            AnswersDict["DATA_SUMMARY_1"] = new List<string>();

            AnswersDict["DATA_CHARACTERISTICS"] = new List<string>() {"In this experiment, {1}." +
                                                                //Projects
                                                                "\n The projects attached are {dmp_project_title} which is about {dmp_project_description}."+
                                                                "\n The project started on: {dmp_project_projectStart}." +
                                                                "\n The project ends on: {dmp_project_projectEnd}." +
                                                                //Funding
                                                                "\n This is a grant with ID {dmp_project_funding_grantID} given by {dmp_project_funding_funderID}." +
                                                                "\n Currently the status of the grant is {dmp_project_funding_fundingStatus}." +
                                                                //Datasets
                                                                "\n With this purpose, the following datasets are required:" +
                                                                "\n {3}." +
                                                                "\n The information contained is in {4} language formatted as {5} about {6}." +
                                                                "\n It does {7} contain sensitive data as well as {8} regarding personal data." +
                                                                "\n To preserve it, {9}." +
                                                                "\n This dataset has been issued on: {10}." +
                                                                "\n The data file has its own Digital Identification {11} which can be accessed through the link: {12} ({13} bytes)" +
                                                                "\n The porpuse of this experment is to {14}." +
                                                                "\n Created on: {15}." +
                                                                "\n Modified on: {16}.",
                                                            "",
                                                            "",
                                                            ""};


            AnswersDict["DOC_METADATA"] = new List<string>() {  "Documentation and Metadata" +
                                                                "\n The following Metadata has been generated: {dataset_metadata_description}" +
                                                                "\n This Metadata is written in {dataset_metadata_languague} Language from the {dataset_metadata_identifier_type} which can be found in {dataset_metadata_identifier_id}." +
                                                                ""+




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
                                                            "\n There are technical resources identified with {technicalResource_TypedIdentifier_ref} with the {technicalResource_TypedIdentifier_Type} code {technicalResource_TypedIdentifier_identifier}.",


                                                            "answer {1}", "answer {1}, {2}",
                                                            "answer {1}", "answer {1}, {2}",


};


            AnswersDict["DATA_AVAILABILITY_STORAGE"] = new List<string>() {
                                                            "Allocation of resources" +
                                                            "FOR EACH C IN COST [" +
                                                            "\n The following resources are involved in the DMP:" +
                                                            "\n {dmp_cost_title}" +
                                                            "\n Type of cost: {dmp_cost_costType}" +
                                                            "\n With a total cost of: {dmp_cost_costValue} in {dmp_cost_costUnit}." +
                                                            "\n The specific purposes are {dmp_cost_description}",
                                                            "]",
                                                            "answer {1}, {2}" };

            AnswersDict["SECURITY_4"] = new List<string>() { "Data Security" +
                                                            "FOR EACH SA IN SECURITYANDPRIVACY" +
                                                            "\n The security {dmp_securityAndPrivacy_title}" +
                                                            "\n {dmp_securityAndPrivacy_description}",
                                                                "answer {1}, {2}" };

            AnswersDict["LEGAL_ETHICAL"] = new List<string>() {"Ethical Aspects" +
                                                           "\n Ethical issues related with the data are involved: {dmp_ethicalIssuesExist}" +
                                                           "\n {dmp_ethicalIssuesDescription}" +
                                                           "\n Find out more in: {dmp_ethicalIssuesReport}",
                                                           "answer {1}, {2}" };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no Other aspects related.", "answer {1}, {2}" };

            return AnswersDict;
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            //QuestionsDict["CONTACT_INFO"] = "1 Data Summary";

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