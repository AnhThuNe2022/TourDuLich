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
    
    public partial class KH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KH()
        {
            this.SoDatTours = new HashSet<SoDatTour>();
        }
    
        public int MaKH { get; set; }
        public decimal SĐT { get; set; }
        public string TenKH { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<decimal> ChungMinhThu { get; set; }
        public string MatKhau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoDatTour> SoDatTours { get; set; }
    }
}