using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Project
    {
        [Key]
        public Guid ID { get; set; }

        public Guid DMPID { get; set; }
        [ForeignKey("DMPID")]
        public virtual DMP DMP { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime ProjectStart { get; set; }
        public DateTime ProjectEnd { get; set; }

        public virtual List<Funding> FundingList { get; set; }
    }
}