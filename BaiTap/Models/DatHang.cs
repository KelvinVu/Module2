//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            this.DatHangCTs = new HashSet<DatHangCT>();
        }
    
        public int DatHangID { get; set; }
        public System.DateTime NgayDatHang { get; set; }
        public double TriGia { get; set; }
        public bool DaGiao { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHangCT> DatHangCTs { get; set; }
    }
}
