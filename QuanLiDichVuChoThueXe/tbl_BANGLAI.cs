//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiDichVuChoThueXe
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_BANGLAI
    {
        public string LoaiXe { get; set; }
        public string YeuCauBangLai { get; set; }
    
        public virtual tbl_LOAIXE tbl_LOAIXE { get; set; }
    }
}