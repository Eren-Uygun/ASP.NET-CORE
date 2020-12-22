using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entity
{
    [Table("country")]
   public class Country
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent  { get; set; }
        public string Region { get; set; }
        public decimal SurfaceArea { get; set; }
        public int IndepYear { get; set; }
        public int Population { get; set; }
        public decimal LifeExpectancy { get; set; }
        public decimal GNP { get; set; }
        public decimal GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int Capital { get; set; }
        public string Code2 { get; set; }

    }
}
