using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1_Winform_QLBV512
{
    class TTBenhnhan
    {
        private String id;
        private String sovv;
        private String ten;
        private String tuoi;
        private String dienthoai;
        private String diachi;
        private String chuyenkhoa;
        DateTime? ngaymo;
        private String chuandoan;
        private String bacsi;
        
        public string Id { get { return id; } set { id = value; } }
        public string Sovv { get => sovv; set => sovv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Tuoi { get => tuoi; set => tuoi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Chuyenkhoa { get => chuyenkhoa; set => chuyenkhoa = value; }
        public DateTime? Ngaymo { get => ngaymo; set => ngaymo = value; }
        public string Chuandoan { get => chuandoan; set => chuandoan = value; }
        public string Bacsi { get => bacsi; set => bacsi = value; }
        
    }
}
