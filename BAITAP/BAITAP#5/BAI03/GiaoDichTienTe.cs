
namespace Bai3Module3
{
    public class GiaoDichTienTe : GiaoDich
    {
        public enum LoaiTienTe
        {
            VND,
            USD,
            EURO
        }
        public LoaiTienTe LoaiTien {  get; set; }
        public decimal TiGia { get; set; }
        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich,
                              decimal donGia, double soLuong,
                              decimal tiGia, LoaiTienTe loaiTien)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            TiGia = tiGia;
            LoaiTien = loaiTien;
        }
        public override decimal ThanhTien()
        {
            if (LoaiTien == LoaiTienTe.USD || LoaiTien == LoaiTienTe.EURO)
                return (decimal)SoLuong * DonGia * TiGia;
            else
                return (decimal)SoLuong * DonGia;
        }

    }
}
