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
    
    public partial class payment
    {
        public payment()
        {
            this.customeraccounts = new HashSet<customeraccount>();
            this.paymentreservationitems = new HashSet<paymentreservationitem>();
            this.reservationitems = new HashSet<reservationitem>();
        }
    
        public long ID { get; set; }
        public long idPaymentMethod { get; set; }
        public long idCustomer { get; set; }
        public Nullable<long> reasonForPayment { get; set; }
        public decimal amount { get; set; }
        public Nullable<bool> isCredit { get; set; }
        public Nullable<long> payDocType { get; set; }
        public string docNumber { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public Nullable<long> idSession { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<customeraccount> customeraccounts { get; set; }
        public virtual paydoctype paydoctype1 { get; set; }
        public virtual paymentmethod paymentmethod { get; set; }
        public virtual reasonforpayment reasonforpayment1 { get; set; }
        public virtual ICollection<paymentreservationitem> paymentreservationitems { get; set; }
        public virtual ICollection<reservationitem> reservationitems { get; set; }
    }
}
