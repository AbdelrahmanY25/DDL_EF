using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_ef.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Sales { get; set; }
        public List<Customer> Customers { get; } = [];
        public List<Store> Stores{ get; } = [];
        public Sale SaleP { get; set; } = null!;
    }
}
