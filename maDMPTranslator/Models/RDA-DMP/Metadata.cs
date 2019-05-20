using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Metadata
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DatasetID { get; set; }

        [ForeignKey("DatasetID")]
        public virtual Dataset Dataset { get; set; }
        public Guid MetadataTypeIdentifierID { get; set; }

        [ForeignKey("MetadataTypeIdentifierID")]
        public TypedIdentifier MetadataTypeIdentifier { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

    }
}