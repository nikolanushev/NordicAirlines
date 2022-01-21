using Nordic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nordic.Models
{
    public class DestinationContext : DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Destination> destinations { get; set; }
        public DestinationContext() : base("DefaultConnection") { }

        public static DestinationContext create()
        {
            return new DestinationContext();
        }
    }
}