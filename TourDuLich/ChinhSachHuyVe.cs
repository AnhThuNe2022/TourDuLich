//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourDuLich
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChinhSachHuyVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChinhSachHuyVe()
        {
            this.HuyTours = new HashSet<HuyTour>();
        }
    
        public string MaTHHuyVe { get; set; }
        public string MoTaTH { get; set; }
        public Nullable<decimal> PhanTramHoanTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HuyTour> HuyTours { get; set; }
    }
}
