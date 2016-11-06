using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        [Display(Name = "Grower")]
        public string UserId { get; set; }
        public int SaleId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string PhotoUrl { get; set; }
        [Display(Name = "Delivery Available")]
        public bool DeliveryAvailable { get; set; }
        public decimal? DeliveryFee { get; set; }
        public int? DeliveryRangeMiles { get; set; }
        [Display(Name = "Available for Donation")]
        public bool CharityAvailable { get; set; }
        public int? CharityId { get; set; }
    }
}