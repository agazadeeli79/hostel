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
    
    public partial class Bed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bed()
        {
            this.Guests = new HashSet<Guest>();
            this.Rezervs = new HashSet<Rezerv>();
        }
    
        public int id { get; set; }
        public string Bed_Number { get; set; }
        public Nullable<int> Type_Id { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> Aviable { get; set; }
        public Nullable<int> Room_Id { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerv> Rezervs { get; set; }
    }
}
