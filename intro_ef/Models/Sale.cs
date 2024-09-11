using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_ef.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId {  get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public Store Store { get; set; } = null!;
    }
}
