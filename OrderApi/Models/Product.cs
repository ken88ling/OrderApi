using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public double Qty { get; set; }
        public DateTime? OrderDateTime { get; set; }
    }
}