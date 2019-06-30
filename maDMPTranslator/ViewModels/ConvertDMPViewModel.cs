using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maDMPTranslator.ViewModels
{
    public class ConvertDMPViewModel
    {
        [Required]
        public HttpPostedFileBase[] Files { get; set; }
        [Required]
        public string Template { get; set; }

        public Models.RDA_DMP.maDMP maDMP { set; get; }
    }
}