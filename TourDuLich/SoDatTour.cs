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
    
    public partial class SoDatTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SoDatTour()
        {
            this.ChiTietDatVes = new HashSet<ChiTietDatVe>();
        }
    
        public string MaDon { get; set; }
        public int MaKH { get; set; }
        public string MaTour { get; set; }
        public Nullable<int> SoPhong { get; set; }
        public string MaGiamGia { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatVe> ChiTietDatVes { get; set; }
        public virtual GiamGia GiamGia { get; set; }
        public virtual KH KH { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
