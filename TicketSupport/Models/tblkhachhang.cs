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
    
    public partial class tblkhachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblkhachhang()
        {
            this.tblyeucauhotrokythuats = new HashSet<tblyeucauhotrokythuat>();
        }
    
        public string ma_khach_hang { get; set; }
        public string ho_ten_khach_hang { get; set; }
        public string email { get; set; }
        public string so_dien_thoai { get; set; }
        public string ten_cong_ty { get; set; }
        public string ma_so_thue { get; set; }
        public string phan_mem { get; set; }
        public string website { get; set; }
        public string mat_khau { get; set; }
        public Nullable<System.DateTime> ngay_kich_hoat { get; set; }
        public Nullable<bool> trang_thai { get; set; }
        public Nullable<System.DateTime> cap_nhat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblyeucauhotrokythuat> tblyeucauhotrokythuats { get; set; }
    }
}
