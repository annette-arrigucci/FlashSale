using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlashSale.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date and Time")]
        public DateTime Date { get; set; }
        [Display(Name = "Number of minutes")]
        public int DurationInMinutes { get; set; }
        public int SaleNotificationId { get; set; }
        public string CreatedByAdminId { get; set; }

        public Sale()
        {
            this.SaleItems = new HashSet<SaleItem>();
        }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}