//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCvProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactTable
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
