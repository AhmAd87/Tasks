using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class UserClass
    {
        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "Username")]
        [StringLength(50, ErrorMessage= "Username  maximum 50 character ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Email Address  maximum 50 character ")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [StringLength(50, ErrorMessage = "Password  maximum 50 character ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Display(Name = "Re-Password")]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        [Display(Name = "Phone Number")]
        [StringLength(20, ErrorMessage = "Phone  maximum 20 character ")]
        public string Phone { get; set; }

    }
}