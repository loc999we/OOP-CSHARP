
namespace Module03
{
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        private string NoiDen;
        private int SoNgay;

        public ChuyenXeNgoaiThanh(
            string maSoChuyen,
            string hoTenTaiXe,
            string soXe,
            double doanhThu,
            string noiDen,
            int soNgay)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            NoiDen = noiDen;
            SoNgay = soNgay;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Nơi đến: {NoiDen}" +
                   $", Số ngày: {SoNgay}";
        }
    }
}
