
namespace Bai2Module3
{
    public class SachThamKhao : Sach
    {
        public double Thue { get; set; }

        public SachThamKhao(string maSach,DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public override decimal TinhThanhTien()
        {
            return (decimal)(SoLuong * DonGia + Thue);
        }
    }
}
