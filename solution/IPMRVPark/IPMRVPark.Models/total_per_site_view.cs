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
    
    public partial class total_per_site_view
    {
        public long idSelected { get; set; }
        public long idSession { get; set; }
        public Nullable<long> idRVSite { get; set; }
        public Nullable<long> idCustomer { get; set; }
        public Nullable<long> idStaff { get; set; }
        public System.DateTime checkInDate { get; set; }
        public System.DateTime checkOutDate { get; set; }
        public bool isSiteChecked { get; set; }
        public long duration { get; set; }
        public string site { get; set; }
        public long idSiteType { get; set; }
        public string period { get; set; }
        public decimal rate { get; set; }
        public decimal total { get; set; }
    }
}
