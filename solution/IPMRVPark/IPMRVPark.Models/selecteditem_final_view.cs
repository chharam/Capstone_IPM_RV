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

    public partial class selecteditem_final_view
    {
        public long ID { get; set; }
        public long idSession { get; set; }
        public Nullable<long> idIPMEvent { get; set; }
        public Nullable<long> idRVSite { get; set; }
        public Nullable<long> idCustomer { get; set; }
        public Nullable<long> idStaff { get; set; }
        public bool isSiteChecked { get; set; }
        public System.DateTime checkInDate { get; set; }
        public System.DateTime checkOutDate { get; set; }
        public string site { get; set; }
        public string siteType { get; set; }
        public int duration { get; set; }
        public int weeks { get; set; }
        public int days { get; set; }
        public decimal weeklyRate { get; set; }
        public decimal dailyRate { get; set; }
        public decimal amount { get; set; }
        public string additionalServicesDescription { get; set; }
        public decimal additionalServicesAmount { get; set; }
        public decimal total { get; set; }
        public Nullable<long> idReservationItem { get; set; }
        public System.DateTime reservationCheckInDate { get; set; }
        public System.DateTime reservationCheckOutDate { get; set; }
        public decimal reservationAmount { get; set; }
        public string reservationAdditionalServDescr { get; set; }
        public decimal reservationAdditionalServAmount { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public string timeStamp { get; set; }
    }
}