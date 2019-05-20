using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class TechnicalResource
    {
        public Guid ID { get; set; }
        public Guid DatasetID { get; set; }
        [ForeignKey("DatasetID")]
        public virtual Dataset Dataset { get; set; }
        public Guid TechnicalResourceTypeIdentifierID { get; set; }

        [ForeignKey("TechnicalResourceTypeIdentifierID")]
        public TypedIdentifier TechnicalResourceTypeIdentifier { get; set; }
        public string Description { get; set; }
    }
}