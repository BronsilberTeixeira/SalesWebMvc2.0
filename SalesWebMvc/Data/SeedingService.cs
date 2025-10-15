using SalesWebMvc.Models;
using SalesWebMvc.Models.Enuns;
using System;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller seller  = new Seller(1, "Bob Brown", "teste@teste", new DateTime(1998, 01, 03), 1000.0, d1);

            SalesRecord r = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, seller);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.Add(seller);
            _context.SalesRecord.Add(r);

        }
    }
}
