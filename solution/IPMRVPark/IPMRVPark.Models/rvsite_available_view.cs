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
    
    public partial class rvsite_available_view
    {
        public long id { get; set; }
        public string site { get; set; }
        public Nullable<long> idIPMEvent { get; set; }
        public long idSiteType { get; set; }
        public string description { get; set; }
        public Nullable<decimal> weeklyRate { get; set; }
        public Nullable<decimal> dailyRate { get; set; }
    }
}