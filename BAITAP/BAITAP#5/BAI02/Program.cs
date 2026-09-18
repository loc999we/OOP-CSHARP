namespace Bai2Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sach> danhSachSach = new List<Sach>
            {
                new SachGiaoKhoa("SGK01", new DateTime(2023, 3, 10), 25_000, 100, "Giáo Dục", "mới"),
                new SachGiaoKhoa("SGK02", new DateTime(2022, 8, 20), 30_000, 50, "Giáo Dục", "cũ"),
                new SachGiaoKhoa("SGK03", new DateTime(2023, 1, 5), 18_000, 200, "Kim Đồng", "mới"),

                new SachThamKhao("STK01", new DateTime(2023, 5, 15), 60_000, 40, "Trẻ", 15_000),
                new SachThamKhao("STK02", new DateTime(2022, 11, 2), 85_000, 20, "Giáo Dục", 25_000),
                new SachThamKhao("STK03", new DateTime(2023, 6, 30), 45_000, 60, "Kim Đồng", 10_000)
            };

            Console.WriteLine("===== DANH SÁCH TẤT CẢ CÁC SÁCH =====");

            foreach (var sach in danhSachSach)
                Console.WriteLine(sach);

            double tongThanhTienGiaoKhoa = danhSachSach
                .OfType<SachGiaoKhoa>()
                .Sum(s => s.TinhThanhTien());

            double tongThanhTienThamKhao = danhSachSach
                .OfType<SachThamKhao>()
                .Sum(s => s.TinhThanhTien());

            Console.WriteLine("\n===== TỔNG THÀNH TIỀN THEO LOẠI =====");
            Console.WriteLine($"Tổng thành tiền sách giáo khoa : {tongThanhTienGiaoKhoa:N0} đ");
            Console.WriteLine($"Tổng thành tiền sách tham khảo : {tongThanhTienThamKhao:N0} đ");

            Console.Write("\nNhập tên nhà xuất bản K cần tìm sách giáo khoa: ");
            string k = Console.ReadLine() ?? "";

            var sachGiaoKhoaTheoNXB = danhSachSach
                .OfType<SachGiaoKhoa>()
                .Where(s => s.NhaXuatBan.Equals(k, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine($"\n===== SÁCH GIÁO KHOA CỦA NHÀ XUẤT BẢN \"{k}\" =====");

            if (sachGiaoKhoaTheoNXB.Count == 0)
                Console.WriteLine("Không tìm thấy sách giáo khoa nào của nhà xuất bản này.");
            else
                foreach (var sach in sachGiaoKhoaTheoNXB)
                    Console.WriteLine(sach);

            var sachThanhTienCaoNhat = danhSachSach
                .OrderByDescending(s => s.TinhThanhTien())
                .First();

            Console.WriteLine("\n===== SÁCH CÓ THÀNH TIỀN CAO NHẤT =====");
            Console.WriteLine(sachThanhTienCaoNhat);

            Console.WriteLine("\nNhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}

