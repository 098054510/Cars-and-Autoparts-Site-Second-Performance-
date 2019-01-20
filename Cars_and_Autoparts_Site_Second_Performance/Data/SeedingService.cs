using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars_and_Autoparts_Site_Second_Performance.Data;
using Cars_and_Autoparts_Site_Second_Performance.Services;

namespace Cars_And_Parts_Site_Second_Performance.Data
{
    public class SeedingService
    {
        private NamelessStoreContext _context;

        public SeedingService(NamelessStoreContext context)
        {
            _context = context;
        }

        public void Seed() //Use this for add more cars, accessories and brands.
        {
            if (_context.Brands.Any() ||
                _context.Cars.Any() ||
                _context.Performance_kit.Any() ||
                _context.Performance_Parts.Any())
            {
                return; // Case Return, the Database has been seeded.
            }

            Performance_parts A4 = new Performance_parts(4, "Surge Tank", 800);
            Performance_parts A8 = new Performance_parts(5, "Camshaft '49g'", 169);

            _context.Performance_Parts.AddRange(A4, A8);
            _context.SaveChanges();

        }
    }
}
