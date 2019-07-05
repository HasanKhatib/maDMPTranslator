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

        public TypedIdentifier dmpID { get; set; }

        public string Language { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
        public YesNoUnkownEnum Ethical_issues_exist { get; set; }
        public string Ethical_issues_reported { get; set; }
        public string Ethical_issues_description { get; set; }


        public Guid ContactID { get; set; }
        [ForeignKey("ContactID")]
        public virtual Contact Contact { get; set; }
        
        public virtual List<DMStaff> DM_staff { get; set; }
        public virtual List<Cost> Cost { get; set; }
        public virtual List<Project> Project { get; set; }
        public virtual List<Dataset> Dataset { get; set; }
    }
}