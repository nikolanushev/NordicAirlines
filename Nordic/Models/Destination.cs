namespace Nordic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Destination
    {
        public Destination()
        {
            Clients = new List<Client>();
        }

        [Key]
        public int DestinationId { get; set; }

        [Required]
        [Display(Name = "Destination")]
        public string DestinationName { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
