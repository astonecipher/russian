//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mech_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Vehicle
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public int vehicleId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
