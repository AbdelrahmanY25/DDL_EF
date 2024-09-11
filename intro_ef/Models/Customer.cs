using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_ef.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? CreaditCardNumber { get; set; }
        public double Sales { get; set; }
        public List<Product> Products { get; } = [];
        public Sale SaleC { get; set; } = null!;
    }
}
