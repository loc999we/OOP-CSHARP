
namespace Bai2Module3
{
    public abstract class Sach
    {
        // Những properties giống nhau giữa 2 loại sách
        public string MaSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }

        // Constructor
        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }

        public abstract decimal TinhThanhTien();
        public override string ToString()
        {
            return $"MaSach: {MaSach}, NgayNhap: {NgayNhap:dd/MM/yyyy}, " +
                   $"DonGia: {DonGia:N0}, SoLuong: {SoLuong}, " +
                   $"NhaXuatBan: {NhaXuatBan}, " +
                   $"ThanhTien: {TinhThanhTien():N0}";
        }
    }
}
