
namespace Bai2Module3
{

    public enum TinhTrangSach
    {
        Sach_Moi,
        Sach_Cu,
    }
    public class SachGiaoKhoa : Sach
    {
        public TinhTrangSach TinhTrang { get; set; }
        
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, TinhTrangSach tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }
        public override decimal TinhThanhTien()
        {
            decimal tt = 0;
            if (TinhTrang == TinhTrangSach.Sach_Moi)
                tt = (decimal)(SoLuong * DonGia);
            else
                tt = (decimal)(SoLuong * DonGia * 0.5);
            return tt;
        }
    }
}
