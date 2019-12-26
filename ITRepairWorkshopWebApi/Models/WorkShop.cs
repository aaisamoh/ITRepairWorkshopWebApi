using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class WorkShop
    {
        [ForeignKey("Device")]
        public int WorkShopID { get; set; }

        [Display(Name = "Processing:")]
        public Processing Processing { get; set; } = 0;

        [Display(Name = "Receipt date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReceiptDate { get; set; } = DateTime.Now;

        [Display(Name = "Expected delivery date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpectedDeliveryDate { get; set; } = DateTime.Now.AddDays(3);

        // many to ONE relationship beetwen two entites(WORKSHOP -part)
        public ICollection<Part> Parts { get; set; }
        public virtual Device Device { get; set; }// One to one (DEVICE-WORKSHOP)
    }
        public enum Processing { Waiting, Ready, Delivery, Retur }// WHAT IS HAPPEND WITH A DEVICE
}
