
namespace Bai2Module3
{
    public class SachGiaoKhoa : Sach
    {
        public string TinhTrang { get; set; }
        public override string LoaiSach
        {
            get
            {
                return "Giáo khoa";
            }
        }

        public SachGiaoKhoa(
            string maSach,
            DateTime ngayNhap,
            double donGia,
            int soLuong,
            string nhaXuatBan,
            string tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }

        public override double TinhThanhTien()
        {
            if (TinhTrang.Equals("mới", StringComparison.OrdinalIgnoreCase))
                return SoLuong * DonGia;

            return SoLuong * DonGia * 0.5;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Tình trạng: {TinhTrang}";
        }
    }
}
