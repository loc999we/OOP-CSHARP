
namespace Bai3Module3
{
    public class GiaoDichTienTe : GiaoDich
    {
        public double TiGia { get; set; }
        public LoaiTienTe LoaiTienTe { get; set; }

        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich,
                              double donGia, double soLuong,
                              double tiGia, LoaiTienTe loaiTienTe)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            TiGia = tiGia;
            LoaiTienTe = loaiTienTe;
        }

        public override string LoaiGiaoDich
        {
            get { return "Tien te"; }
        }

        public override double TinhThanhTien()
        {
            if (LoaiTienTe == LoaiTienTe.USD ||
                LoaiTienTe == LoaiTienTe.EUR)
            {
                return SoLuong * DonGia * TiGia;
            }

            return SoLuong * DonGia;
        }
    }
}
