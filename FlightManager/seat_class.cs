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
    
    public partial class seat_class
    {
        public string flight_id { get; set; }
        public int seat_type { get; set; }
        public Nullable<int> seat_number { get; set; }
    
        public virtual flight flight { get; set; }
        public virtual seat_type seat_type1 { get; set; }
    }
}