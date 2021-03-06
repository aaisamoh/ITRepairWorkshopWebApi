﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Display(Name = "Name:")]
        [Required(ErrorMessage = "Enter sn of name of the client!")]
        public string Name { get; set; }

        [Display(Name = "Adress:")]
        public string Adress { get; set; } = null;

        [Display(Name = "Telephone:")]
        public string Telephone { get; set; } = null;

        [Display(Name = "Country:")]
        public string Country { get; set; } = null;

        [Display(Name = "City:")]
        public string City { get; set; } = null;

        [Display(Name = "Password:")]
        public string Password { get; set; } = null;

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Enter email !")]
        [EmailAddress(ErrorMessage = "Invalid address!")]
        public string Email { get; set; }

        [Display(Name = "Have you Access ?:")]
        public HaveAccess HaveAccess { get; set; } = 0; //Allow or deny access to the Internet
       // [Display(Name = "Group:")]
       // public group Group  { get; set; }

        public ICollection<Device> Devices { get; set; }
        public ICollection<ImpartPart> ReserveOParts { get; set; }

        public Client()
        {
            Devices = new List<Device>();
            ReserveOParts = new List<ImpartPart>();
        }
      
    }
    public enum HaveAccess { Deny,Allow } //client that belongs to a group
}
