using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OurMVCpp.Models
{
    public class Login
    {    [Required(ErrorMessage ="Name is Required")]
         [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "User Password")]
        [DataType(DataType.Password)]
        public string  UserPwd { get; set; }
    }
}