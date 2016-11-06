using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class Grower : ApplicationUser
    {
        public int TaxId { get; set; }

        public Grower()
        {
            this.SaleItems = new HashSet<SaleItem>();
        }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}