//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPMRVPark.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation_view
    {
        public long idReservationItem { get; set; }
        public long idRVSite { get; set; }
        public long idCustomer { get; set; }
        public string RVSite { get; set; }
        public string fullName { get; set; }
        public System.DateTime checkInlDate { get; set; }
        public System.DateTime checkOutDate { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public int numberMemberInParty { get; set; }
        public Nullable<bool> isCancelled { get; set; }
    }
}
