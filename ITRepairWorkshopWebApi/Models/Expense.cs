using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }
        [Display(Name = "Value:")]
        public int Value { get; set; } = 0;
        [Display(Name = "Target:")]
        public Target Target { get; set; }
        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; } = DateTime.Now;
        [Display(Name = "Description:")]
        public string Description { get; set; }

    }
    public enum Target {Hire, Moms,Oil, Postal,Transpart, Other }
}
