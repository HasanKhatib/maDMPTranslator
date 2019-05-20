using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class SecurityAndPrivacy
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DatasetID { get; set; }
        [ForeignKey("DatasetID")]
        public virtual Dataset Dataset { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}