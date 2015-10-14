//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class Account
    {
        public int AccountId { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [EmailAddress]
        [Display(Name = "Email")]
        [StringLength(500)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int AccountTypeId { get; set; }
        
        public virtual AccountType AccountType { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}