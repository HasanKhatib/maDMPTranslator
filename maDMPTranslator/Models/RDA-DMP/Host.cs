using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Host
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DistributionID { get; set; }

        [ForeignKey("DistributionID")]
        public virtual Distribution Distribution { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public YesNoUnkownEnum SupportsVersioning { get; set; }
        public string BackupType { set; get; }
        public string FackupFrequency { get; set; }
        public string StorageType { get; set; }
        public string Availability { get; set; }

        public List<string> CertifiedWithList { get; set; }
        public string GeoLocation { get; set; }
        public string PIDSystem { set; get; }
    }
}