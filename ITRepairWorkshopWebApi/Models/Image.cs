using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        [Display(Name = "Dir:")]
        public string Dir { get; set; }
        [Display(Name = "Status:")]
        public Status Status { get; set; }

        public int? DeviceID { get; set; }
        public Device Device { get; set; }

        public int? PartID { get; set; }
        public Part  Part { get; set; }
    }
   public  enum Status {Part,Device,Logo }
}
