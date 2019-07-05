using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static maDMPTranslator.Models.Utils.EnumUtils;

namespace maDMPTranslator.Models.RDA_DMP
{
    public class Distribution
    {
        [Key]
        public Guid ID { get; set; }
        public Guid DatasetID { get; set; }

        [ForeignKey("DatasetID")]
        public virtual Dataset Dataset { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string ByteSize { get; set; }
        public string AccessURL { get; set; }
        public string DownloadURL { get; set; }
        public string MediaType { get; set; }
        public DataAccessEnum DataAccess { set; get; }
        public DateTime AvailableTill { get; set; }
        public List<License> license { get; set; }
    }
}