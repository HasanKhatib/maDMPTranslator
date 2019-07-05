using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Contact
    {
        [Key]
        public Guid ID { get; set; }

        public Guid DMPID { get; set; }
        [ForeignKey("DMPID")]
        public virtual DMP DMP { get; set; }

        public TypedIdentifier contact_id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}