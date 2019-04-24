using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitatyion_WebApp.Models
{
    public class GuestResponse //creating guest response class to collect information about participants
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your name")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your E-mail address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid E-mail address")]

        public string Phone { get; set; }
        [Required (ErrorMessage ="Please enter your phone number")]

        public bool? WillAttend { get; set;}
    }
}
