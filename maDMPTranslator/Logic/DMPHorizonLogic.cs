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
        public Dictionary<string, List<string>> AnswersDict = null;

        public Dictionary<string, List<string>> InitializeAnswersDict()
        {
            //1: project description
            //2: dataset.size
            //3: datasets titles (joined)
            //4: language
            //5: dataset type
            //6 dataset_description
            //7 dataset_sensitive_data
            //8 dataset_personal_data
            //9 preservation_statement
            //10 dataset_issued
            //11 dataset_datasetID_type
            //12 dataset_datasetID
            //13 dataset_distribution_byteSize
            //14 dmp_description
            AnswersDict["DATA_SUMMARY "] = new List<string>() {"In this experiment, {1}." +
                                                                "\n With this purpose, the following datasets are required:" +
                                                                "\n {3}." +
                                                                "\n The information contained is in {4} language formatted as {5} about {6}." +
                                                                " It does {7} contain sensitive data as well as {8} regarding personal data. " +
                                                                "{9}.\n This dataset has been issued on: {10}." +
                                                                "\n The data file has its own Digital Identification {11} which can be accessed through the link " +
                                                                "{12}, its total size is of {13} bytes.\n",
                                                            "The porpuse of this experment is to {1}.",
                                                            "",
                                                            "",
                                                            ""};


            AnswersDict["DATA_SUMMARY_1"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["DATA_SUMMARY_1_1"] = "What is the purpose of the data collection/generation and its relation to the objectives of the project?";
            //AnswersDict["DATA_SUMMARY_1_2"] = "What types and formats of data will the project generate/collect?";
            //AnswersDict["DATA_SUMMARY_1_3"] = "Will you re-use any existing data and how?";
            //AnswersDict["DATA_SUMMARY_1_4"] = "What is the origin of the data?";
            //AnswersDict["DATA_SUMMARY_1_5"] = "What is the expected size of the data?";
            //AnswersDict["DATA_SUMMARY_1_6"] = "To whom might it be useful ('data utility')?";

            AnswersDict["FAIR_2_1"] = new List<string>() {
                                                            "answer {1}", "answer {1}, {2}",
                                                            "answer {1}", "answer {1}, {2}",


};

            //AnswersDict["FAIR_2_1_1"] = "Are the data produced and/or used in the project discoverable with metadata, identifiable and locatable by means of a standard identification mechanism (e.g. persistent and unique identifiers such as Digital Object Identifiers)?";
            //AnswersDict["FAIR_2_1_2"] = "What naming conventions do you follow?";
            //AnswersDict["FAIR_2_1_3"] = "Will search keywords be provided that optimize possibilities for re-use?";
            //AnswersDict["FAIR_2_1_4"] = "Do you provide clear version numbers?";
            //AnswersDict["FAIR_2_1_5"] = "What metadata will be created? In case metadata standards do not exist in your discipline, please outline what type of metadata will be created and how.";

            AnswersDict["FAIR_2_2"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["FAIR_2_2_1"] = "Which data produced and/or used in the project will be made openly available as the default? If certain datasets cannot be shared (or need to be shared under restrictions), explain why, clearly separating legal and contractual reasons from voluntary restrictions.";
            //AnswersDict["FAIR_2_2_2"] = "Note that in multi-beneficiary projects it is also possible for specific beneficiaries to keep their data closed if relevant provisions are made in the consortium agreement and are in line with the reasons for opting out.";
            //AnswersDict["FAIR_2_2_3"] = "How will the data be made accessible (e.g. by deposition in a repository)?";
            //AnswersDict["FAIR_2_2_4"] = "What methods or software tools are needed to access the data?";
            //AnswersDict["FAIR_2_2_5"] = "Is documentation about the software needed to access the data included?";
            //AnswersDict["FAIR_2_2_6"] = "Is it possible to include the relevant software (e.g. in open source code)?";
            //AnswersDict["FAIR_2_2_7"] = "Where will the data and associated metadata, documentation and code be deposited? Preference should be given to certified repositories which support open access where possible.";
            //AnswersDict["FAIR_2_2_8"] = "Have you explored appropriate arrangements with the identified repository?";
            //AnswersDict["FAIR_2_2_9"] = "If there are restrictions on use, how will access be provided?";
            //AnswersDict["FAIR_2_2_10"] = "Is there a need for a data access committee?";
            //AnswersDict["FAIR_2_2_11"] = "Are there well described conditions for access (i.e. a machine readable license)?";
            //AnswersDict["FAIR_2_2_12"] = "How will the identity of the person accessing the data be ascertained?";

            AnswersDict["FAIR_2_3"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["FAIR_2_3_1"] = "Are the data produced in the project interoperable, that is allowing data exchange and re-use between researchers, institutions, organisations, countries, etc. (i.e. adhering to standards for formats, as much as possible compliant with available (open) software applications, and in particular facilitating re-combinations with different datasets from different origins)?";
            //AnswersDict["FAIR_2_3_2"] = "What data and metadata vocabularies, standards or methodologies will you follow to make your data interoperable?";
            //AnswersDict["FAIR_2_3_3"] = "Will you be using standard vocabularies for all data types present in your data set, to allow inter-disciplinary interoperability?";
            //AnswersDict["FAIR_2_3_4"] = "In case it is unavoidable that you use uncommon or generate project specific ontologies or vocabularies, will you provide mappings to more commonly used ontologies?";

            AnswersDict["FAIR_2_4"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["FAIR_2_4_1"] = "How will the data be licensed to permit the widest re-use possible?";
            //AnswersDict["FAIR_2_4_2"] = "When will the data be made available for re-use? If an embargo is sought to give time to publish or seek patents, specify why and how long this will apply, bearing in mind that research data should be made available as soon as possible.";
            //AnswersDict["FAIR_2_4_3"] = "Are the data produced and/or used in the project useable by third parties, in particular after the end of the project? If the re-use of some data is restricted, explain why.";
            //AnswersDict["FAIR_2_4_4"] = "How long is it intended that the data remains re-usable?";
            //AnswersDict["FAIR_2_4_5"] = "Are data quality assurance processes described?";

            AnswersDict["ALLOCATION_3"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["ALLOCATION_3_1"] = "What are the costs for making data FAIR in your project?";
            //AnswersDict["ALLOCATION_3_2"] = "How will these be covered? Note that costs related to open access to research data are eligible as part of the Horizon 2020 grant (if compliant with the Grant Agreement conditions).";
            //AnswersDict["ALLOCATION_3_3"] = "Who will be responsible for data management in your project?";
            //AnswersDict["ALLOCATION_3_4"] = "Are the resources for long term preservation discussed (costs and potential value, who decides and how what data will be kept and for how long)?";

            AnswersDict["SECURITY_4"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["SECURITY_4_1"] = "What provisions are in place for data security (including data recovery as well as secure storage and transfer of sensitive data)?";
            //AnswersDict["SECURITY_4_2"] = "Is the data safely stored in certified repositories for long term preservation and curation?";

            AnswersDict["ETHICAL_5"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["ETHICAL_5_1"] = "Are there any ethical or legal issues that can have an impact on data sharing? These can also be discussed in the context of the ethics review. If relevant, include references to ethics deliverables and ethics chapter in the Description of the Action (DoA).";
            //AnswersDict["ETHICAL_5_2"] = "Is informed consent for data sharing and long term preservation included in questionnaires dealing with personal data?";

            AnswersDict["OTHER_6"] = new List<string>() { "answer {1}", "answer {1}, {2}" };

            //AnswersDict["OTHER_6"] = "Do you make use of other national/funder/sectorial/departmental procedures for data management? If yes, which ones?";

            //AnswersDict["OTHER_6"] = "Other issues";

            //AnswersDict["ETHICAL_4_1_"] = "AAAA";


            return AnswersDict;
        }

        public Dictionary<string, string> InitializeQuestionsDict()
        {
            QuestionsDict["DATA_SUMMARY_1"] = "Data Summary";

            //QuestionsDict["DATA_SUMMARY_1_1"] = "What is the purpose of the data collection/generation and its relation to the objectives of the project?";
            //QuestionsDict["DATA_SUMMARY_1_2"] = "What types and formats of data will the project generate/collect?";
            //QuestionsDict["DATA_SUMMARY_1_3"] = "Will you re-use any existing data and how?";
            //QuestionsDict["DATA_SUMMARY_1_4"] = "What is the origin of the data?";
            //QuestionsDict["DATA_SUMMARY_1_5"] = "What is the expected size of the data?";
            //QuestionsDict["DATA_SUMMARY_1_6"] = "To whom might it be useful ('data utility')?";

            QuestionsDict["FAIR_2_1"] = "Making data findable, including provisions for metadata";

            //QuestionsDict["FAIR_2_1_1"] = "Are the data produced and/or used in the project discoverable with metadata, identifiable and locatable by means of a standard identification mechanism (e.g. persistent and unique identifiers such as Digital Object Identifiers)?";
            //QuestionsDict["FAIR_2_1_2"] = "What naming conventions do you follow?";
            //QuestionsDict["FAIR_2_1_3"] = "Will search keywords be provided that optimize possibilities for re-use?";
            //QuestionsDict["FAIR_2_1_4"] = "Do you provide clear version numbers?";
            //QuestionsDict["FAIR_2_1_5"] = "What metadata will be created? In case metadata standards do not exist in your discipline, please outline what type of metadata will be created and how.";

            QuestionsDict["FAIR_2_2"] = "Making data openly accessible";

            //QuestionsDict["FAIR_2_2_1"] = "Which data produced and/or used in the project will be made openly available as the default? If certain datasets cannot be shared (or need to be shared under restrictions), explain why, clearly separating legal and contractual reasons from voluntary restrictions.";
            //QuestionsDict["FAIR_2_2_2"] = "Note that in multi-beneficiary projects it is also possible for specific beneficiaries to keep their data closed if relevant provisions are made in the consortium agreement and are in line with the reasons for opting out.";
            //QuestionsDict["FAIR_2_2_3"] = "How will the data be made accessible (e.g. by deposition in a repository)?";
            //QuestionsDict["FAIR_2_2_4"] = "What methods or software tools are needed to access the data?";
            //QuestionsDict["FAIR_2_2_5"] = "Is documentation about the software needed to access the data included?";
            //QuestionsDict["FAIR_2_2_6"] = "Is it possible to include the relevant software (e.g. in open source code)?";
            //QuestionsDict["FAIR_2_2_7"] = "Where will the data and associated metadata, documentation and code be deposited? Preference should be given to certified repositories which support open access where possible.";
            //QuestionsDict["FAIR_2_2_8"] = "Have you explored appropriate arrangements with the identified repository?";
            //QuestionsDict["FAIR_2_2_9"] = "If there are restrictions on use, how will access be provided?";
            //QuestionsDict["FAIR_2_2_10"] = "Is there a need for a data access committee?";
            //QuestionsDict["FAIR_2_2_11"] = "Are there well described conditions for access (i.e. a machine readable license)?";
            //QuestionsDict["FAIR_2_2_12"] = "How will the identity of the person accessing the data be ascertained?";

            QuestionsDict["FAIR_2_3"] = "Making data interoperable";

            //QuestionsDict["FAIR_2_3_1"] = "Are the data produced in the project interoperable, that is allowing data exchange and re-use between researchers, institutions, organisations, countries, etc. (i.e. adhering to standards for formats, as much as possible compliant with available (open) software applications, and in particular facilitating re-combinations with different datasets from different origins)?";
            //QuestionsDict["FAIR_2_3_2"] = "What data and metadata vocabularies, standards or methodologies will you follow to make your data interoperable?";
            //QuestionsDict["FAIR_2_3_3"] = "Will you be using standard vocabularies for all data types present in your data set, to allow inter-disciplinary interoperability?";
            //QuestionsDict["FAIR_2_3_4"] = "In case it is unavoidable that you use uncommon or generate project specific ontologies or vocabularies, will you provide mappings to more commonly used ontologies?";

            QuestionsDict["FAIR_2_4"] = "Increase data re-use (through clarifying licences)";

            //QuestionsDict["FAIR_2_4_1"] = "How will the data be licensed to permit the widest re-use possible?";
            //QuestionsDict["FAIR_2_4_2"] = "When will the data be made available for re-use? If an embargo is sought to give time to publish or seek patents, specify why and how long this will apply, bearing in mind that research data should be made available as soon as possible.";
            //QuestionsDict["FAIR_2_4_3"] = "Are the data produced and/or used in the project useable by third parties, in particular after the end of the project? If the re-use of some data is restricted, explain why.";
            //QuestionsDict["FAIR_2_4_4"] = "How long is it intended that the data remains re-usable?";
            //QuestionsDict["FAIR_2_4_5"] = "Are data quality assurance processes described?";

            QuestionsDict["ALLOCATION_3"] = "Allocation of resources";

            //QuestionsDict["ALLOCATION_3_1"] = "What are the costs for making data FAIR in your project?";
            //QuestionsDict["ALLOCATION_3_2"] = "How will these be covered? Note that costs related to open access to research data are eligible as part of the Horizon 2020 grant (if compliant with the Grant Agreement conditions).";
            //QuestionsDict["ALLOCATION_3_3"] = "Who will be responsible for data management in your project?";
            //QuestionsDict["ALLOCATION_3_4"] = "Are the resources for long term preservation discussed (costs and potential value, who decides and how what data will be kept and for how long)?";

            QuestionsDict["SECURITY_4"] = "Data Security";

            //QuestionsDict["SECURITY_4_1"] = "What provisions are in place for data security (including data recovery as well as secure storage and transfer of sensitive data)?";
            //QuestionsDict["SECURITY_4_2"] = "Is the data safely stored in certified repositories for long term preservation and curation?";

            QuestionsDict["ETHICAL_5"] = "Ethical aspects";

            //QuestionsDict["ETHICAL_5_1"] = "Are there any ethical or legal issues that can have an impact on data sharing? These can also be discussed in the context of the ethics review. If relevant, include references to ethics deliverables and ethics chapter in the Description of the Action (DoA).";
            //QuestionsDict["ETHICAL_5_2"] = "Is informed consent for data sharing and long term preservation included in questionnaires dealing with personal data?";

            QuestionsDict["OTHER_6"] = "Other issues";

            //QuestionsDict["OTHER_6"] = "Do you make use of other national/funder/sectorial/departmental procedures for data management? If yes, which ones?";

            //QuestionsDict["OTHER_6"] = "Other issues";

            //QuestionsDict["ETHICAL_4_1_"] = "AAAA";

            return QuestionsDict;



        }
    }
}