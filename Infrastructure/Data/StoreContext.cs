using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products {get; set;}
    }
}