//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketSupport.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblnguoidung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblnguoidung()
        {
            this.tbllichsuthaydoiyeucaus = new HashSet<tbllichsuthaydoiyeucau>();
            this.tblphongbans = new HashSet<tblphongban>();
        }
    
        public string ma_nguoi_dung { get; set; }
        public string ho_ten_nguoi_dung { get; set; }
        public string ten_dang_nhap { get; set; }
        public string email { get; set; }
        public string so_dien_thoai { get; set; }
        public string mat_khau { get; set; }
        public Nullable<bool> trang_thai { get; set; }
        public string token { get; set; }
        public Nullable<System.DateTime> token_expire { get; set; }
        public Nullable<System.DateTime> ngay_tao { get; set; }
        public Nullable<System.DateTime> cap_nhat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbllichsuthaydoiyeucau> tbllichsuthaydoiyeucaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblphongban> tblphongbans { get; set; }
    }
}
