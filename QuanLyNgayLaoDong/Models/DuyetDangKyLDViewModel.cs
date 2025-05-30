using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace QuanLyNgayLaoDong.Models
{
    public class DuyetDangKyLDViewModel
    {
        public int STT { get; set; }
        public string DotLaoDong { get; set; }
        public DateTime? NgayLaoDong { get; set; }
        public string LoaiLaoDong { get; set; }
        public int? GiaTri { get; set; }
        public int SoLuongSinhVien { get; set; }
        public string TrangThai { get; set; } 
        public int DotLaoDongId { get; set; }
    }
}