using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SOLID_Principles.SRP.Model
{
    public class Product
    {
        public Guid ID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }

       [DataType(DataType.Currency),Range(0,double.MaxValue)]
        public decimal? UnitPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ProductAddDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ProductExpireDate { get; set; }

        [Range(0,5)] // 0 Hiç istenmeyen 5 En çok talep edilen
        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }
}
