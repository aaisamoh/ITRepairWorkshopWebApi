using System;
using System.Linq;

namespace ITRepairWorkshopWebApi.Models
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if(!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                         Name="Ahmad", Email="ahamad@gmail.com", Telephone="1288898129"
                    },
                     new Client
                     {
                         Name = "Amad",
                         Email = "aamad@gmail.com",
                         Telephone = "138898129", HaveAccess=HaveAccess.Deny
                     }

                    );
            }
            
            if (!context.Parts.Any())
            {
                context.Parts.AddRange(
                    new Part
                    {
                       Guid="rrwer_23232", Quantity=2, MaxPriceOfSale=23, MinPriceOfSale=13
                         
                    },
                    new Part
                    {
                        Guid = "zzwer_23232",
                        Quantity = 2,
                        MaxPriceOfSale = 43,
                        MinPriceOfSale = 23

                    },
                     new Part
                     {
                         Guid = "VVwer_44442",
                         Quantity = 1,
                         MaxPriceOfSale = 63,
                         MinPriceOfSale = 43

                     }
                    );
                         context.SaveChanges();
            }
            if (!context.Devices.Any())
            {
                context.Devices.AddRange(
                    new Device
                    {
                        SourceOfdevice = SourceOfdevice.Servicing,
                        StatusOfDevice = StatusOfDevice.Notworking,
                        Category = DeviceCategory.Mobile,
                        Brand = CompanyBrand.Samsung,
                        SN = "CV7234672646634",
                        ModelOfDevice = "SM-383F",
                        Details = "SLKDFS",
                        ClientID = 1,

                    },
                    new Device
                    {
                        SourceOfdevice = SourceOfdevice.Servicing,
                        StatusOfDevice = StatusOfDevice.Notworking,
                        Category = DeviceCategory.Computer,
                        Brand = CompanyBrand.Lenovo,
                        SN = "XXCV7234672646634",
                        ModelOfDevice = "LENOVO2565",
                        Details = "SLKDFS",
                        ClientID = 2,

                    },
                      new Device
                        {
                           SourceOfdevice = SourceOfdevice.Servicing,
                           StatusOfDevice = StatusOfDevice.Notworking,
                           Category = DeviceCategory.Computer,
                            Brand = CompanyBrand.Dell,
                            SN = "DELL7234672646634",
                            ModelOfDevice = "DELL2565",
                            Details = "THIS IS THE DELL",
                            ClientID = 2,

                      }
                    );

            }
                if (!context.WorkShops.Any())
                {
                       context.WorkShops.AddRange(
                        new WorkShop
                        {
                         
                            WorkShopID = 3,
                        }

                        ); 
                }
            if (!context.Bills.Any())
            {
                context.Bills.AddRange(
                    new Bill
                    {
                         BillTarget= BillTarget.Device, BillFor= BillFor.Repair,  BillID=1
                       
                    }

                    );
            }
            context.SaveChanges();
        }  
    }
}
