using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_ef.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; } = null!;
        public double Sales { get; set; }
        public List<Product> Products { get; } = [];
        public Sale SaleS { get; set; } = null!;
    }
}
