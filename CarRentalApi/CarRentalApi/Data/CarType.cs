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
    
    public partial class CarType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarType()
        {
            this.Cars = new HashSet<Car>();
        }
    
        public int TypeId { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public double DailyRate { get; set; }
        public double LateRate { get; set; }
        public int Year { get; set; }
        public bool IsManual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
