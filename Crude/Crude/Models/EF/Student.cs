//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crude.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please provie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provie Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provie Address")]
        public string Address { get; set; }
    }
}