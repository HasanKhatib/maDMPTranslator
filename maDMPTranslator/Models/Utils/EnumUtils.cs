using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.Utils
{
    public class EnumUtils
    {
        /// <summary>
        /// Used in dataset class
        /// </summary>
        public enum YesNoUnkownEnum
        {
            Yes, No, Unknown
        }
        /// <summary>
        /// Used in cost class
        /// </summary>
        public enum CostUnitEnum
        {
            USD, EUR
        }
        /// <summary>
        /// Used in cost class
        /// </summary>
        public enum CostTypeEnum
        {
            Type1, Type2
        }
        /// <summary>
        /// Used in funding class
        /// </summary>
        public enum FundingStatusEnum
        {
            Planned, Applied, Granted, Rejected
        }
        /// <summary>
        /// Used in Distribution class
        /// </summary>
        public enum DataAccessEnum {
            Open,Closed,Shared
        }
        /// <summary>
        /// Used in TypeIdentifier Class
        /// </summary>
        public enum IdentifierTypeEnum {
            ORCID,DOI,URI,HTTPURL,HTTP_ORCID
        }
        /// <summary>
        /// Used in DMStaff class
        /// </summary>
        public enum ContributionTypeEnum
        {
            Single
        }
        /// <summary>
        /// Used in Dataset class
        /// </summary>
        public enum DatasetTypeEnum {
            CSV,PDF,DOC,DOCS
        }
    }
}