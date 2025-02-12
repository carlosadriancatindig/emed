﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EMedFinalProject.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string Code { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please enter a valid LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "FirstName is Required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please enter a valid FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Delivery Address is Required")]
        public string DeliveryAddress { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }
        [Display(Name = "Order Status")]
        public OrderStatus? Status { get; set; }

        [Required(ErrorMessage = "Contact No. is Required")]
        [RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Please enter a valid Contact No.")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Please enter a valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prescription is Required")]
        [Display(Name = "Prescription Image")]
        public string Prescription { get; set; }

        [Required(ErrorMessage = "A Valid ID is Required")]
        [Display(Name = "Valid ID Image")]
        public string ValidID { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public enum OrderStatus
    {
        Pending = 1,
        Confirmed = 2
    }
}
