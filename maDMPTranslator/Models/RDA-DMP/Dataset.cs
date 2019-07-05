using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Dataset
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DMPID { get; set; }
        [ForeignKey("DMPID")]
        public DMP DMP { get; set; }

        public Guid DatasetTypeIdentifierID { get; set; }
        [ForeignKey("DatasetTypeIdentifierID")]
        public TypedIdentifier DatasetTypeIdentifier { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        //ToDo: DatasetType should follow enum values
        public string Type { get; set; }
        public string metadata { get; set; }
        public string Keywords { get; set; }
        public virtual List<string> KeywordsList
        {
            get { return string.IsNullOrEmpty(Keywords) ? new List<string>() : Keywords.Split(',').ToList(); }
        }

        public string Issued { get; set; }
        public string Language { get; set; }
        public YesNoUnkownEnum Personal_data { get; set; }
        public YesNoUnkownEnum Sensitive_data { get; set; }
        public string DataQualityAussurance { get; set; }
        public string PreservationStatement { get; set; }

        public List<SecurityAndPrivacy> security_and_privacy { get; set; }
        public List<TechnicalResource> TechnicalResourcesList { get; set; }
        public List<Metadata> MetadataList { get; set; }
        public List<Distribution> distribution { get; set; }
    }
}