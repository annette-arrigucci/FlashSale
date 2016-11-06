using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class Customer : ApplicationUser
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        public virtual ICollection<Order> Orders { get; set; }
    }
}