﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace QLNK.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhMucKhuPho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucKhuPho()
        {
            this.DanhMucKhuVucs = new HashSet<DanhMucKhuVuc>();
            this.DanhMucToDanPhoes = new HashSet<DanhMucToDanPho>();
        }
    
        public int Id { get; set; }
        [DisplayName("Tên viết tắt")]
        public string TenVietTat { get; set; }
        [DisplayName("Tên khu phố")]
        public string TenDayDu { get; set; }
        [DisplayName("Trạng thái")]
        public bool TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMucKhuVuc> DanhMucKhuVucs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMucToDanPho> DanhMucToDanPhoes { get; set; }
    }
}
