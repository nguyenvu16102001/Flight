//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.accounts = new HashSet<account>();
        }
    
        public int user_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string identity_card { get; set; }
        public string nationality { get; set; }
        public string avatar { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<account> accounts { get; set; }
        public virtual customer customer { get; set; }
        public virtual employee employee { get; set; }
    }
}
