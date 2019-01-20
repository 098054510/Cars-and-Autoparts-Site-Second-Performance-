﻿using Cars_and_Autoparts_Site_Second_Performance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_and_Autoparts_Site_Second_Performance.Services
{
    public class Brand
    {
        private readonly NamelessStoreContext _context;

        public Brand(NamelessStoreContext context)
        {
            _context = context;
        }

        public List<Brand> FindAll()
        {
            return _context.Brands.ToList();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Brand()
        {
        }

        public Brand(int ID, string Name, string Country)
        {
            this.ID = ID;
            this.Name = Name;
            this.Country = Country;
        }
    }
}
