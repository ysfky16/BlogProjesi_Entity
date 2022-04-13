using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogProjesi_Entity.Models.Siniflar
{
    public class Yetenekler
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string YetenekAdi { get; set; }

        public byte YetenekYuzde { get; set; }  
    }
}