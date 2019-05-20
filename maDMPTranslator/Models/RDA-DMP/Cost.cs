﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Cost
    {
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("DMPID")]
        public virtual DMP DMP { get; set; }
        public Guid DMPID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CostTypeEnum CostType { get; set; }
        public int CostValue { get; set; }
        public CostUnitEnum CostUnit { get; set; }
    }
}