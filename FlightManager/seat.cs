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
    
    public partial class seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seat()
        {
            this.tickets = new HashSet<ticket>();
        }
    
        public int seat_id { get; set; }
        public string seat_name { get; set; }
        public Nullable<int> seat_type { get; set; }
        public Nullable<short> active { get; set; }
        public string airplane_id { get; set; }
    
        public virtual seat_type seat_type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticket> tickets { get; set; }
    }
}
