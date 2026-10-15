
namespace Bai3Module3
{
    public abstract class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }

        public GiaoDich(string maGiaoDich, DateTime ngayGiaoDich,
                        decimal donGia, double soLuong)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public abstract decimal ThanhTien();
        public override string ToString()
        {
            return $"Mã giao dịch: {MaGiaoDich} || Ngày giao dịch: {NgayGiaoDich} "+
                   $"|| Đơn giá: {DonGia} || Số lượng: {SoLuong}";
        }
    }
}
