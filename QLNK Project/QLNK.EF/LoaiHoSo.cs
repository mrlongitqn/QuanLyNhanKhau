//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNK.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiHoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiHoSo()
        {
            this.HoKhaus = new HashSet<HoKhau>();
        }
    
        public int Id { get; set; }
        public string TenVietTat { get; set; }
        public string TenLoai { get; set; }
        public bool TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoKhau> HoKhaus { get; set; }
    }
}
