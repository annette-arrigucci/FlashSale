using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class SaleNotification
    {
        public int Id { get; set; }
        public DateTime TimeToSend { get; set; }
    }
}