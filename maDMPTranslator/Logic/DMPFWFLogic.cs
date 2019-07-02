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
                                                                
                                                                //Data Management Plan {dmp_title}
                                                                //"\n The porpuse of this experment is to {dmp_description}." +
                                                                //"\n The language of the experiment in is {dmp_language}" + 
                                                                //"\n Created on: {dmp_created}." +
                                                                //"\n Modified on: {dmp_modified}.",


            
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
            //15 dataset_keyword

            AnswersDict["DATA_CHARACTERISTICS"] = new List<string>() {
                                                                "Description of the data" +
                                                                "The data was generated for {0}." +
                                                                "The keyword related to this data are: {15}" +

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

            
            //0: dataset_metadata_description
            //1: dataset_metadata_languague
            //2: dataset_metadata_identifier_type
            //3: dataset_metadata_identifier_id
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

            AnswersDict["DOC_METADATA"] = new List<string>() {  

                                                            "Documentation and Metadata" +
                                                            //"\n Metadata Standards" +
                                                            "\n The following Metadata has been generated: {0}" +
                                                            "\n This Metadata is written in {1} Language following the standard from the {2} which can be found in {3}." +
                                                                
                                                            //"\n Documentation of data" +
                                                            //"In order to align the experiment with the basics principles of FAIR " +
                                                            //"the following information has been also attached to this DMP:\n" +

                                                            //"FOR EACH DS IN DATASET ["+
                                                            //"\n {dataset_title}" +
                                                            //"\n Keywords: FOR EACH KW IN keyword {dataset_keyword}" +
                                                            //"\n To have a better understanding of the data, the following Metadata has been generated: {dataset_metadata_description}\n" +
                                                            //"\n This Metadata is written in {dataset_metadata_languague} Language from the {dataset_metadata_identifier_type} which can be found in {dataset_metadata_identifier_id}.\n" +
                                                            

                                                            //"\n Data Quality Control"+
                                                            "\n The processes adopted to assurance the quality of the data are: {dataset_data_quality_assurance}\n",
                                                            
                                                            "answer {1}", "answer {1}, {2}",
                                                            "answer {1}", "answer {1}, {2}",


};
            //0: dataset_distribution_dataAccess
            //1: dataset_distribution_accessURL
            //2: dataset_distribution_downloadURL
            //3: dataset_distribution_availableTill
            //4: dataset_distribution_license_license_ref
            //5: dataset_distribution_license_startDate
            //6: dataset_distribution_format
            //7: dataset_distribution_size
            //8: dataset_distribution_host_title
            //9: dataset_distribution_host_geoLocation
            //10: dataset_distribution_host_availability
            //11: dataset_distribution_host_description
            //12: dataset_distribution_host_storageType
            //13: dataset_distribution_host_supportsVersioning
            //14: dataset_distribution_host_pidSystem
            //15: dataset_distribution_host_certifiedWith
            //16: dataset_distribution_host_backupType
            //17: dataset_distribution_host_backupFrequancy
            //18: technicalResource_TypedIdentifier_ref
            //19: technicalResource_TypedIdentifier_Type
            //20: technicalResource_TypedIdentifier_identifier
            //21: dmp_cost_title
            //22: dmp_cost_costType
            //23: dmp_cost_costValue
            //24: dmp_cost_costUnit
            //25: dmp_cost_description
            //26: dmp_securityAndPrivacy_title
            //27: 

            AnswersDict["DATA_AVAILABILITY_STORAGE"] = new List<string>() { 


                                                            "Data Avalability and Storage" +
                                                            "\n Data sharing strategy" +
                                                            "\n The Access to the data is {0} by the URL: {1} \n" +
                                                            "\n To Download it, use the link: {2} \n" +
                                                            "\n Available until: {3}\n" +
                                                            "\n The information is under the license {4} starting on {5}.\n" + 
                                                           
                                                            "\n Data storage strategy" +
                                                            "\n The data is stored in format {6} and size {7} bytes\n" +
                                                            "\n The Repository used has the following specifications: \n" +
                                                            "\n Name: {8}.\n" +
                                                            "\n Located in: {9}.\n" +
                                                            "\n The availability is {10}%.\n" +
                                                            "\n This is a repository of {11}." +

                                                            "\n With a technology base on {12}, that {13} regarding versioning support.\n" +
                                                            "\n The PID System is: {14}.\n" +
                                                            "\n Certified with: {15}.\n" +
                                                            "\n The Backup process consists on {16}; the tasks run regularly with a frequency of {17}."+
                                                            


                                                            "\n Technical Resources" +
                                                            "\n There are technical resources identified with {18} with the {19} code {20}." +

                                                            "\n Allocation of resources" +
                                                            "\n The following resources are involved in the DMP:" +
                                                            "\n {21}" +
                                                            "\n Type of cost: {22}" +
                                                            "\n With a total cost of: {23} in {24}." +
                                                            "\n The specific purposes are {25}" +

                                                            "\n Data Security" +
                                                            "\n The are security aspects as {26}" +
                                                            "\n Wich consists in {27}",
                                                        

                                                            "answer {1}, {2}" };
            //0: dmp_ethicalIssuesExist
            //1: dmp_ethicalIssuesDescription
            //2: dmp_ethicalIssuesReport
            //3: 
            //4: 
            //5: 
            //6: 
            //7: 

            AnswersDict["LEGAL_ETHICAL"] = new List<string>() {
                                                           "\n Ethical Aspects" +
                                                           "\n Ethical issues related with the data are involved: {0}" +
                                                           "\n {1}" +
                                                           "\n Find out more in: {2}",
                                                           "answer {1}, {2}" };

            AnswersDict["OTHER_6"] = new List<string>() { "There are no other aspects related.", "answer {1}, {2}" };


            return AnswersDict;
        }



        public Dictionary<string, string> InitializeQuestionsDict()
        {
            throw new NotImplementedException();
        }
    }
}