
namespace Bai3Module3
{
    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public double DonGia { get; set; }
        public double SoLuong { get; set; }

        public GiaoDich(string maGiaoDich, DateTime ngayGiaoDich,
                        double donGia, double soLuong)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public virtual string LoaiGiaoDich
        {
            get { return "Giao dich"; }
        }

        public virtual double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}
