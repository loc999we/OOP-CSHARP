
namespace Bai3Module3
{
    public class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }

        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich,
                            decimal donGia, double soLuong, string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }

        public override decimal ThanhTien()
        {
            return (decimal)SoLuong * DonGia;
        }
    }
}
