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

        public Dictionary<string, List<string>> InitializeAnswersDict(Models.RDA_DMP.maDMP maDMP)
        {
            //There might be some initial information like this:
                                                                
                                                                //Data Management Plan
                                                                //"\n The porpuse of this experment is to {14}." +
                                                                //"\n Created on: {15}." +
                                                                //"\n Modified on: {16}.",


            
            //0: dmp_contact_name
            //1: dmp_contact_mbox
            //2: dmp_contact_contactID_identifierType
            //3: dmp_contact_contactID_identifier
            //4: dmp_dmStaff_contributor_type
            //5: dmp_contact_name
            //6: dmp_contact_mbox
            //7: dmp_contact_contactID_identifierType
            //8: dmp_contact_contactID_identifier
            //9: 
            //10: 


            AnswersDict["DATA_OFFICER"] = new List<string>() {"The responsible for this Data Management Plan (DMP) is: {0}" +
                                                                "\n email: {1}" +
                                                                "\n with ID from {2}" +
                                                                "\n ({3})" +
                                                                "The staff involved in the experiment is integrated by"+
                                                                "FOR EACH STAFF IN DMSTAFF [" +
                                                                "\n The responsale for {4} is: {5}" +
                                                                "\n email: {6}" +
                                                                "\n with ID from {7}" +
                                                                "\n ({8})",
                                                                
                                                                "DONE YYY Answer2 {0}"


                };
            //0: dmp_description
            //1: dmp_project_description
            //2: dmp_project_projectStart
            //3: dmp_project_projectEnd
            //4: datasets titles (joined)
            //5: language
            //6: dataset type
            //7 dataset_description
            //8 dataset_sensitive_data
            //9 dataset_personal_data
            //10 preservation_statement
            //11 dataset_issued
            //12 dataset_datasetID_type
            //13 dataset_datasetID
            //14 dataset_distribution_byteSize

            AnswersDict["DATA_CHARACTERISTICS"] = new List<string>() {
                                                                "Description of the data" +
                                                                "The data was generated for {0}." +


                                                                //Projects
                                                                "\n More specifically it consists in {1}."+
                                                                "\n The project started on: {2}." +
                                                                "\n The project ends on: {3}." +
                                                                //Datasets
                                                                "\n With this purpose, the following datasets are generated:" +
                                                                "\n {4}." +
                                                                "\n The information contained is in {5} language formatted as {6} about {7}." +
                                                                "\n It does {8} contain sensitive data as well as {9} regarding personal data." +
                                                                "\n To preserve it, some actions have to be taken as {10}." +
                                                                "\n This dataset has been issued on: {11}." +
                                                                "\n The data file has its own Digital Identification {12} which can be accessed through the link: {13} ({14} bytes)",
                                                                
                                                              
                                                            "",
                                                            "",
                                                            ""};

            //1: 
            //2: 
            //3: 
            //4: 
            //5: 
            //6: 
            //7: 
            //8: 
            //9: 
            //10: 
            //11: 
            //12: 
            //13: 
            //: 

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

            //1: 
            //2: 
            //3: 
            //4: 
            //5: 
            //6: 
            //7: 
            //8: 
            //9: 
            //10: 
            //11: 
            //12: 
            //13: 
            //: 

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
            //1: 
            //2: 
            //3: 
            //4: 
            //5: 
            //6: 
            //7: 
            //8: 
            //9: 
            //10: 
            //11: 
            //12: 
            //13: 
            //: 

            AnswersDict["SECURITY_4"] = new List<string>() { "Data Security" +
                                                            "FOR EACH SA IN SECURITYANDPRIVACY" +
                                                            "\n The security {dmp_securityAndPrivacy_title}" +
                                                            "\n {dmp_securityAndPrivacy_description}",
                                                                "answer {1}, {2}" };
            //1: 
            //2: 
            //3: 
            //4: 
            //5: 
            //6: 
            //7: 
            //8: 
            //9: 
            //10: 
            //11: 
            //12: 
            //13: 
            //: 
            AnswersDict["LEGAL_ETHICAL"] = new List<string>() {"Ethical Aspects" +
                                                           "\n Ethical issues related with the data are involved: {dmp_ethicalIssuesExist}" +
                                                           "\n {dmp_ethicalIssuesDescription}" +
                                                           "\n Find out more in: {dmp_ethicalIssuesReport}",
                                                           "answer {1}, {2}" };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no Other aspects related.", "answer {1}, {2}" };

            //AnswersDict["OTHER_6"] = "Do you make use of other national/funder/sectorial/departmental procedures for data management? If yes, which ones?";

            //AnswersDict["OTHER_6"] = "Other issues";

            //AnswersDict["ETHICAL_4_1_"] = "AAAA";

                                                                            //Funding
                                                                //"\n This is a grant with ID {dmp_project_funding_grantID} given by {dmp_project_funding_funderID}." +
                                                                //"\n Currently the status of the grant is {dmp_project_funding_fundingStatus}." +


            return AnswersDict;
        }



        public Dictionary<string, string> InitializeQuestionsDict()
        {
            throw new NotImplementedException();
        }
    }
}