using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapideneme.Models
{
    public class DavetiyeModel
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Eposta { get; set; }
        [Required]
        public Boolean KatilmaDurumu { get; set; }
    }
}