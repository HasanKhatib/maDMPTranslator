using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class TypedIdentifier
    {
        [Key]
        public string contact_id { get; set; }
        public IdentifierTypeEnum contact_id_type { get; set; }
    }
}