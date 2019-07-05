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
        public string DistributionID { get; set; }
        [ForeignKey("DistributionID")]
        public virtual Distribution Distribution { get; set; }
        public string license_ref { get; set; }
        public string active_from { get; set; }
        public string start_date { get; set; }
    }
}