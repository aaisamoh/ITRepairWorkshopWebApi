using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    // Create a bill by getting some parts to  repair  a device
    public class PartsForWorkShop
    {
        [Key]
        public int PartsForWorkShopID { get; set; }

        public int? BillID { get; set; }
        public Bill Bill { get; set; }
         
        public int? WorkShopID { get; set; }
        public WorkShop WorkShop { get; set; }

        public ICollection<Part> Parts { get; set; }
        public PartsForWorkShop()
        {
            Parts = new List<Part>();
        }
    }
}
