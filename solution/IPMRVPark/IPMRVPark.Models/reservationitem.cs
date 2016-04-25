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
    
    public partial class reservationitem
    {
        public reservationitem()
        {
            this.checkinouts = new HashSet<checkinout>();
            this.customeraccounts = new HashSet<customeraccount>();
            this.paymentreservationitems = new HashSet<paymentreservationitem>();
            this.reservationitem_partymember = new HashSet<reservationitem_partymember>();
            this.selecteditems = new HashSet<selecteditem>();
        }
    
        public long ID { get; set; }
        public long idIPMEvent { get; set; }
        public long idRVSite { get; set; }
        public long idCustomer { get; set; }
        public long idStaff { get; set; }
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
        public int numberMemberInParty { get; set; }
        public bool isCancelled { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public string timeStamp { get; set; }
    
        public virtual ICollection<checkinout> checkinouts { get; set; }
        public virtual customer customer { get; set; }
        public virtual ICollection<customeraccount> customeraccounts { get; set; }
        public virtual ipmevent ipmevent { get; set; }
        public virtual ICollection<paymentreservationitem> paymentreservationitems { get; set; }
        public virtual placeinmap placeinmap { get; set; }
        public virtual staff staff { get; set; }
        public virtual ICollection<reservationitem_partymember> reservationitem_partymember { get; set; }
        public virtual ICollection<selecteditem> selecteditems { get; set; }
    }
}
