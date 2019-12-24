using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class Device
    {
        [Key]
        public int DeviceID { get; set; }
        [Display(Name = "Category:")]
        public DeviceCategory Category { get; set; }

        [Display(Name = "Brand:")]
        public CompanyBrand Brand { get; set; }

        //  id of the device
         public string GuidOfDevice => Category + "_" + Brand + ModelOfDevice.TrimStart('_')+DeviceID;

        [Display(Name = "Model:")]
        [Required(ErrorMessage = "Enter model of the device!")]
        public string ModelOfDevice { get; set; }

        [Display(Name = "Serial number:")]
        [Required(ErrorMessage = "Enter sn of device!")]
        public string SN { get; set; }

        [Display(Name = "Price of Purchase:")]
        public float PriceOfPurchase { get; set; } = 0;

        [Display(Name = "Price of sale 1:")]
        public float MaxPriceofSale { get; set; } = 0;

        [Display(Name = "Price of sale 2:")]
        public float MinPriceOfSale { get; set; } = 0;

        [Display(Name = "Details:")]
        public string Details { get; set; }
      
        public int? ClientID { get; set; }
        public Client Client { get; set; }

        //add the images
        public ICollection<Image> Images { get; set; }
        public Device()
        {
            Images = new List<Image>();          
        }

        [Display(Name = "Source:")]
        public SourceOfdevice SourceOfdevice { get; set; }

        [Display(Name = "Status:")]
        public StatusOfDevice StatusOfDevice { get; set; }

       public virtual WorkShop Shop{ get; set; }// One to one relationship between two entities (WORKSHOP-DEVICE)
       public virtual Bill Bill { get; set; }// One to one relationship between two entities (BILL-DEVICE)
    }
    //From where are the devices came to the store.
    public enum SourceOfdevice { Purchase,Servicing }
    // Damage-the device need servicing.
    public enum StatusOfDevice { Working, Notworking }
    public enum CompanyBrand { Samsung, Sony,HP,Apple,Iphone,Asus,LG,Acer,Lenovo,Dell,Toshibo,Siemens,Compag,Hauwei,Other }
    public enum DeviceCategory { Mobile,Computer,Ipad,PS,Printer,TV,Other}
}
