using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class License
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DistributionID { get; set; }
        [ForeignKey("DistributionID")]
        public virtual Distribution Distribution { get; set; }
        public string License_ref { get; set; }
        public DateTime StartDate { get; set; }
    }
}