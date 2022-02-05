using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porto_ecommerce_30_.Models
{
    public class PortoDbContext:DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options){ }
        public DbSet<Category> categories { get; set; }
    }
}
