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
    
    public partial class party
    {
        public party()
        {
            this.partymembers = new HashSet<partymember>();
            this.reservationitems = new HashSet<reservationitem>();
        }
    
        public int idParty { get; set; }
        public Nullable<int> numberOfMembers { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual ICollection<partymember> partymembers { get; set; }
        public virtual ICollection<reservationitem> reservationitems { get; set; }
    }
}
