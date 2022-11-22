﻿using Pay1194.Entity;
using System.ComponentModel.DataAnnotations;

namespace Pay1194.Models
{
    public class PayIndexViewModel
    {

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; }
        [Display(Name = "Month")]
        public string PayMonth { get; set; }
        public int TaxYearId { get; set; }
        public string Year { get; set; }
        [Display(Name = "Total Earnings")]
        public decimal TotalEarnings { get; set; }
        [Display(Name = "Total Deductions")]
        public decimal TotalDeduction { get; set; }
        [Display(Name = "Net")]
        public decimal NetPayment { get; set; }


    }
}
