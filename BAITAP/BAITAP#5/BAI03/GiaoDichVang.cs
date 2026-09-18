
namespace Bai3Module3
{
    public class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }

        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich,
                            double donGia, double soLuong, string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }

        public override string LoaiGiaoDich
        {
            get { return "Vang"; }
        }

        public override double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}
