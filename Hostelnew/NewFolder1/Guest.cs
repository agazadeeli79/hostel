//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hostelnew.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guest
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VSID { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<int> Bed_Id { get; set; }
    
        public virtual Bed Bed { get; set; }
    }
}
