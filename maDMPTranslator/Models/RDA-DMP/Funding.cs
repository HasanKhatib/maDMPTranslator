using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Funding
    {
        [Key]
        public Guid ID { get; set; }

        public Guid ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }

        public Guid GrantTypeIdentifierID { get; set; }
        [ForeignKey("GrantTypeIdentifierID")]
        public TypedIdentifier GrantTypeIdentifier { get; set; }

        public Guid FunderTypeIdentifierID { get; set; }
        [ForeignKey("FunderTypeIdentifierID")]
        public TypedIdentifier FunderTypeIdentifier { get; set; }

        public FundingStatusEnum FundingStatus { get; set; }
    }
}