using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public Order()
        {
            this.SaleItems = new HashSet<SaleItem>();
        }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}