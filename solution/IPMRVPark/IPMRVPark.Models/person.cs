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
    
    public partial class person
    {
        public int idPerson { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mainPhone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual partymember partymember { get; set; }
        public virtual staff staff { get; set; }
    }
}
