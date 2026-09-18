
namespace Module03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ChuyenXe> danhSach = new List<ChuyenXe>();

            // 2 chuyến xe nội thành
            danhSach.Add(new ChuyenXeNoiThanh(
                "NT01",
                "Nguyen Van An",
                "59A-12345",
                500000,
                5,
                120));

            danhSach.Add(new ChuyenXeNoiThanh(
                "NT02",
                "Tran Van Binh",
                "59A-67890",
                700000,
                7,
                180));

            // 2 chuyến xe ngoại thành
            danhSach.Add(new ChuyenXeNgoaiThanh(
                "NG01",
                "Le Van Cuong",
                "51B-11111",
                1500000,
                "Vung Tau",
                2));

            danhSach.Add(new ChuyenXeNgoaiThanh(
                "NG02",
                "Pham Van Dung",
                "51B-22222",
                2000000,
                "Da Lat",
                3));

            // Xuất danh sách
            Console.WriteLine("DANH SACH CHUYEN XE");
            Console.WriteLine("-------------------------------");

            foreach (ChuyenXe xe in danhSach)
            {
                Console.WriteLine(xe);
            }

            // Tính tổng doanh thu
            double TongDoanhThu = 0;
            double DoanhThuNoiThanh = 0;
            double DoanhThuNgoaiThanh = 0;

            foreach (ChuyenXe xe in danhSach)
            {
                TongDoanhThu += xe.TinhDoanhThu();

                if (xe is ChuyenXeNoiThanh)
                {
                    DoanhThuNoiThanh += xe.TinhDoanhThu();
                }
                else if (xe is ChuyenXeNgoaiThanh)
                {
                    DoanhThuNgoaiThanh += xe.TinhDoanhThu();
                }
            }

            Console.WriteLine();
            Console.WriteLine("TONG DOANH THU TAT CA CHUYEN XE: "
                              + TongDoanhThu);

            Console.WriteLine("TONG DOANH THU NOI THANH: "
                              + DoanhThuNoiThanh);

            Console.WriteLine("TONG DOANH THU NGOAI THANH: "
                              + DoanhThuNgoaiThanh);
        }
    }
}
