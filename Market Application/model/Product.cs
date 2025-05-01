using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Application.model
{
    public class Product
    {
        public int id { get; set; }
        public string qrCode { get; set; }
        public string barkodCode { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime updateDate { get; set; }
        public string productName { get; set; }
        public float weight { get; set; }
        public int price { get; set; }
        public int turnover { get; set; }
    }
}
