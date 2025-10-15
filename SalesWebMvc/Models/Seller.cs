using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        public Department department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.date >= initial && sr.date <= final).Sum(sr => sr.amount);

            //Outra forma de ser feito (sem LINQ)

            //double total = 0.0;
            //foreach (var sr in Sales)
            //{
            //    if (sr.date >= initial && sr.date <= final)
            //    {
            //        total += sr.amount;
            //    }
            //}
            //return total;
        }
    }
}
