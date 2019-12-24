﻿using System.ComponentModel.DataAnnotations;

namespace ITRepairWorkshopWebApi.Models
{
    public class Part
    {
        [Key]       
        public int PartID { get; set; }
       
        [Display(Name = "UnikID:")]
        //  id of the part
        public string Guid { get; set; }
        [Required]
           
        [Display(Name = "Quantity:")]
        public int Quantity { get; set; } = 1;

        [Display(Name = "Price of sale 1:")]
        public float MaxPriceOfSale { get; set; } = 0;

        [Display(Name = "Price of sale 2:")]
        public float MinPriceOfSale { get; set; } = 0;


        // many to ONE relationship beetwen two entites(Bill -part)
        public Bill Bill { get; set; }
        public int ? BillID { get; set; }

    }

}
