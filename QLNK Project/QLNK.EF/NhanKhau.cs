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
    
    public partial class NhanKhau
    {
        public int Id { get; set; }
        public int MaChuHo { get; set; }
        public string TenVietTat { get; set; }
        public string TenDayDu { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string HoKhauThuongTru { get; set; }
        public string DenTuNoi { get; set; }
        public string NgheNghiep { get; set; }
        public string QuanHeChuHo { get; set; }
        public System.DateTime NgayDangKy { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
    
        public virtual HoKhau HoKhau { get; set; }
    }
}
