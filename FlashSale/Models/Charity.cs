using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class Charity : ApplicationUser
    {
        public int TaxId { get; set; }
    }
}