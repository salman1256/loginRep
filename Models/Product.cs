using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OurMVCpp.Models
{
    public class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }
        public DateTime PMfDate { get; set; }
    }
}