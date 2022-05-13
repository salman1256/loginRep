using OurMVCpp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurMVCpp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> proList = new List<Product>()
            { 
            new Product
            { PId=1,PName="Herbal Shampoo",PPrice=123.56,PMfDate=new DateTime(day:12,month:12,year:2012)},
             new Product
            { PId=1,PName="Dabur Honey",PPrice=123.56,PMfDate=new DateTime(day:12,month:12,year:2021)},
              new Product
            { PId=2,PName="Jambo Cooler",PPrice=3000.40,PMfDate=new DateTime(day:03,month:02,year:2022)},
               new Product
            { PId=4,PName="Laptop",PPrice=109000.50,PMfDate=new DateTime(day:12,month:04,year:2021)},
                new Product
            { PId=3,PName="M-Phone",PPrice=87000.50,PMfDate=new DateTime(day:20,month:09,year:2020)},
            };
            return View(proList);
        }
    }
}