using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nordic.Models
{
    public class Client
    {
        public Client()
        {
            Destinations = new List<Destination>();
        }

        [Key]
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ClientName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public String DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Departure")]
        public DateTime DateOfDeparture { get; set; }

        public IEnumerable<SelectListItem> Destination { get; set; }
        
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}