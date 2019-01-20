using Cars_and_Autoparts_Site_Second_Performance.Data;
using System.Linq;
using System.Collections.Generic;

namespace Cars_and_Autoparts_Site_Second_Performance.Services
{
    public class Performance_kit
    {
        private readonly NamelessStoreContext _context;

        public Performance_kit(NamelessStoreContext context)
        {
            _context = context;
        }
        
        public List<Performance_kit> FindAll()
        {
            return _context.Performance_kits.ToList();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Performance_kit()
        {
        }

        public Performance_kit(int ID, string Name, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }
    }
}
