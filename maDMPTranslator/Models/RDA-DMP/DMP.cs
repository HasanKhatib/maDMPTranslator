using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class DMP
    {
        [Key]
        public Guid ID { get; set; }

        public Guid DMPTypeIdentifierID { get; set; }
        [ForeignKey("DMPTypeIdentifierID")]
        public TypedIdentifier DMPTypeIdentifier { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public YesNoUnkownEnum EthicalIssues { get; set; }
        public string EthicalIssuesReport { get; set; }
        public string EthicalIssuesDescription { get; set; }


        public Guid ContactID { get; set; }
        [ForeignKey("ContactID")]
        public virtual Contact Contact { get; set; }
        
        public virtual List<DMStaff> DMStaff { get; set; }
        public virtual List<Cost> CostList { get; set; }
        public virtual List<Project> ProjectsList { get; set; }
        public virtual List<Dataset> DatasetList { get; set; }
    }
}