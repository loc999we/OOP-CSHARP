
namespace Bai3Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tao danh sach giao dich
            List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>
            {
                // 3 giao dich vang
                new GiaoDichVang(
                    "GDV01",
                    new DateTime(2024, 1, 10),
                    75000000,
                    2,
                    "SJC"),

                new GiaoDichVang(
                    "GDV02",
                    new DateTime(2024, 2, 15),
                    1200000000,
                    1.5,
                    "PNJ"),

                new GiaoDichVang(
                    "GDV03",
                    new DateTime(2024, 3, 20),
                    76000000,
                    3,
                    "SJC"),

                // 3 giao dich tien te
                new GiaoDichTienTe(
                    "GDT01",
                    new DateTime(2024, 1, 12),
                    24500,
                    40000,
                    1,
                    LoaiTienTe.VND),

                new GiaoDichTienTe(
                    "GDT02",
                    new DateTime(2024, 2, 18),
                    24800,
                    50000,
                    25000,
                    LoaiTienTe.USD),

                new GiaoDichTienTe(
                    "GDT03",
                    new DateTime(2024, 3, 25),
                    27000,
                    20000,
                    27000,
                    LoaiTienTe.EUR)
            };


            // 1. Tong so luong giao dich vang
            double tongSoLuongVang = 0;

            // 2. Tong so luong giao dich tien te
            double tongSoLuongTienTe = 0;

            foreach (GiaoDich gd in danhSachGiaoDich)
            {
                if (gd is GiaoDichVang)
                {
                    tongSoLuongVang += gd.SoLuong;
                }
                else if (gd is GiaoDichTienTe)
                {
                    tongSoLuongTienTe += gd.SoLuong;
                }
            }

            Console.WriteLine("Tong so luong giao dich vang: " + tongSoLuongVang);
            Console.WriteLine("Tong so luong giao dich tien te: " + tongSoLuongTienTe);


            // 3. Trung binh thanh tien cua giao dich tien te
            double tongThanhTienTienTe = 0;
            int soGiaoDichTienTe = 0;

            foreach (GiaoDich gd in danhSachGiaoDich)
            {
                if (gd is GiaoDichTienTe)
                {
                    tongThanhTienTienTe += gd.TinhThanhTien();
                    soGiaoDichTienTe++;
                }
            }

            double trungBinhThanhTien = 0;

            if (soGiaoDichTienTe > 0)
            {
                trungBinhThanhTien = tongThanhTienTienTe / soGiaoDichTienTe;
            }

            Console.WriteLine(
                "Trung binh thanh tien giao dich tien te: "
                + trungBinhThanhTien.ToString("N0"));


            // 4. Xuat cac giao dich co don gia > 1 ty
            Console.WriteLine();
            Console.WriteLine("Cac giao dich co don gia > 1 ty:");

            foreach (GiaoDich gd in danhSachGiaoDich)
            {
                if (gd.DonGia > 1000000000)
                {
                    Console.WriteLine(
                        gd.MaGiaoDich
                        + " - Don gia: "
                        + gd.DonGia.ToString("N0"));
                }
            }
        }
    }
}
        
        
    
