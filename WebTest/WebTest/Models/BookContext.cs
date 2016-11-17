using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebTest.Models
{
    public class BookContext : DbContext
    {
        public DbSet<BookModels> Books { get; set; }
        public DbSet<PurchaseModels> Purchases { get; set; }
    }
}