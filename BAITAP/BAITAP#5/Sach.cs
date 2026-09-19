
namespace Bai2Module3
{
    public class Sach
    {
        public string MaSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }

        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }

        public virtual string LoaiSach
        {
            get
            {
                return "Sách";
            }
        }
        public virtual double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return $"[{LoaiSach}] Mã sách: {MaSach} | NXB: {NhaXuatBan} | Ngày nhập: {NgayNhap:dd/MM/yyyy} | " +
                   $"Đơn giá: {DonGia:N0} đ | SL: {SoLuong} | Thành tiền: {TinhThanhTien():N0} đ";
        }
    }
}
