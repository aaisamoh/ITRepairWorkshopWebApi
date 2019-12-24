using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class Bill
    {
        [ForeignKey("Device")]
        public int BillID { get; set; } 

        [Display(Name = "Target:")]
        public BillTarget BillTarget { get; set; } = 0;

        [Display(Name = "For:")]
        public BillFor BillFor { get; set; } = 0;
        public string GUID => BillTarget + "-" + BillFor + BillID;
      
        [Display(Name = "Moms:")]
        public int MOMS { get; set; } = 0;

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BillDate { get; set; } = DateTime.Now;
        // many to ONE relationship beetwen two entites(Bill -part)
        public ICollection<Part> Parts { get; set; }
        public virtual Device Device { get; set; }// One to one relationship between two entities (BILL-DEVICE)
    }
    public enum BillFor { Purchase, Sale, Delivery, Retur,Repair }
    public enum BillTarget { Device, Part }
}
