//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int CarId { get; set; }
        public int TypeId { get; set; }
        public int Milage { get; set; }
        public byte[] Image { get; set; }
        public bool Functional { get; set; }
        public bool Available { get; set; }
        public string PlateNumber { get; set; }
        public int BranchId { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual CarType CarType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
