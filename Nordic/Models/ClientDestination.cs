using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nordic.Models
{
    public class ClientDestination
    {
        public List<Destination> Destinations { get; set; }
        public Client Client{ get; set; }
        public int DestinationId { get; set; }
        public int ClientId { get; set; }
    }
}