using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Departament
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament() 
        {
        }
        public Departament(int id, String name)
        {
            this.id = id;
            this.Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales (DateTime inicial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inicial, final));
        }
    }
}
