//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int OrderId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime ActualEndDate { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
