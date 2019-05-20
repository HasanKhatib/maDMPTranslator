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
        public Guid ID { get; set; }
        public string Identifier { get; set; }
        public IdentifierTypeEnum IdentifierType { get; set; }
    }
}