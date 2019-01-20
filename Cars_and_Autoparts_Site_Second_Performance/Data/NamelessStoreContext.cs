﻿using Cars_and_Autoparts_Site_Second_Performance.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_and_Autoparts_Site_Second_Performance.Data
{
    public class NamelessStoreContext : DbContext
    {
        public NamelessStoreContext(DbContextOptions<NamelessStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Performance_kit> Performance_kits { get; set; }
        public DbSet<Performance_parts> Performance_Parts { get; set; }
    }
}
