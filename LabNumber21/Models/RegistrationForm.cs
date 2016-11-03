using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LabNumber21.Models
{
    public class RegistrationForm
    {
        //[Required(ErrorMessage = "Please enter your name")]
        [Required(ErrorMessage = "Please enter your  Firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Second name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter your Age")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Please enter your Type of Study")]
        public string TypeOfStudy { get; set; }



      
    }
}