
namespace Bai2Module3
{
    public class SachThamKhao : Sach
    {
        public double Thue { get; set; }
        public override string LoaiSach
        {
            get
            {
                return "Tham khảo";
            }
        }
        public SachThamKhao(
            string maSach,
            DateTime ngayNhap,
            double donGia,
            int soLuong,
            string nhaXuatBan,
            double thue)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public override double TinhThanhTien()
        {
            return SoLuong * DonGia + Thue;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Thuế: {Thue:N0} đ";
        }
    }
}
