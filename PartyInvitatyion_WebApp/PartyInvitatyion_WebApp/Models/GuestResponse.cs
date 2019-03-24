using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitatyion_WebApp.Models
{
    public class GuestResponse //creating guest response class to collect information about participants
    {
        public string Name { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}
        public bool? WillAttend { get; set;}
    }
}
