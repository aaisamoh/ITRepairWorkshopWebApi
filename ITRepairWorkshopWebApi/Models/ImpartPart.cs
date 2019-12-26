using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class ImpartPart
    {
        [Key]
        public  int PartID { get; set; }
       
        [Display(Name = "Category:")]
        public  DeviceCategory DeviceCategory { get; set; }

        [Display(Name = "Brand:")]
        public  CompanyBrand CompanyBrand { get; set; }

        [Display(Name = "Model:")]
        [Required(ErrorMessage = "Enter model of device!")]
        public string ModelOfPart { get; set; }


        //  id of the partModelOfPart.TrimStart('-') + DeviceCategory + CompanyBrand + PartID;
        public string PartGuid { get; set; } =$"PartID";
   

        [Required]
        [Display(Name = "Title:")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Booking date:")]
         public DateTime? BookingDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Estimated date:")]
        public DateTime EstimatedDate { get; set; } = DateTime.Now.AddDays(5);//estimated time of arrival

        [Display(Name = "Tracking number:")]
        public string TrackingNumber { get; set; } = null;

        [Display(Name = "Price of purchase:")]
        public float PriceOfPurchase { get; set; } = 0;

        [Display(Name = "Quantity:")]
        public int Quantity { get; set; } = 1;

        public float MinPriceOfSale { get; set; } = 0;
        [Display(Name = "Details:")]
        public string Details { get; set; }

        // ADD a client
        public int? ClientID { get; set; }

        public Client Client { get; set; }
        //add the images
        public ICollection<Image> Images { get; set; }
     
        public ImpartPart()
        {
            this.Images = new List<Image>(); 
        }

        // One to one -impartPART AND PART
        public virtual Part Part { get; set; }

        [Display(Name = "Status:")]
        public StatusOfPart StatusOfPart { get; set; } = StatusOfPart.Reserve;

        [Display(Name = "Source:")]
        public SourceOfPart SourceOfPart { get; set; } = SourceOfPart.Purchase;
        // Two differents TYPES Of parts  
        [Display(Name = "Type:")]
        public TypeOfPart TypeOfPart { get; set; }

    }
    public enum StatusOfPart { Delivery=0, Reserve=1, Retur=2 }
    public enum SourceOfPart { Purchase, Damage }
    public enum TypeOfPart { Electronic, Accessories }
}
