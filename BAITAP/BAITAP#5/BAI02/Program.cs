using static System.Reflection.Metadata.BlobBuilder;

namespace Bai2Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sach> books = new List<Sach>();
            {
                books.Add(new SachGiaoKhoa("SGK01", new DateTime(2023, 3, 10), 25_000, 100, "Giao Duc", TinhTrangSach.Sach_Moi));
                books.Add(new SachGiaoKhoa("SGK02", new DateTime(2022, 8, 20), 30_000, 50, "Giao Duc", TinhTrangSach.Sach_Cu));
                books.Add(new SachGiaoKhoa("SGK03", new DateTime(2023, 1, 5), 18_000, 200, "Kim Dong", TinhTrangSach.Sach_Moi));

                books.Add(new SachThamKhao("STK01", new DateTime(2023, 5, 15), 60_000, 40, "Tre", 15_000));
                books.Add(new SachThamKhao("STK02", new DateTime(2022, 11, 2), 85_000, 20, "Giao Duc", 25_000));
                books.Add(new SachThamKhao("STK03", new DateTime(2023, 6, 30), 45_000, 60, "Kim Dong", 10_000));
            }
            ;
            decimal tienSGK = 0, tienSTK = 0;
            foreach (var book in books)
            {
                Console.Write(book);
                Console.WriteLine($", Thanh tien: {book.TinhThanhTien()}");
                if (book is SachGiaoKhoa)
                    tienSGK += book.TinhThanhTien();
                else
                    tienSTK += book.TinhThanhTien();
            }

            Console.Write("Nhập tên NXB:");
            string nxb = Console.ReadLine()!;
            foreach (var book in books)
            {
                if (string.Equals(book.NhaXuatBan, nxb, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}


