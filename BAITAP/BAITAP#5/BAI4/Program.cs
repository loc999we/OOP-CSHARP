namespace Bai2Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachSach danhSach = new DanhSachSach(10);
            List<Sach> danhSachSach = new List<Sach>
            {
                new SachGiaoKhoa("SGK01", new DateTime(2023, 3, 10), 25_000, 100, "Giao Duc", "moi"),
                new SachGiaoKhoa("SGK02", new DateTime(2022, 8, 20), 30_000, 50, "Giao Duc", "cu"),
                new SachGiaoKhoa("SGK03", new DateTime(2023, 1, 5), 18_000, 200, "Kim Dong", "moi"),

                new SachThamKhao("STK01", new DateTime(2023, 5, 15), 60_000, 40, "Tre", 15_000),
                new SachThamKhao("STK02", new DateTime(2022, 11, 2), 85_000, 20, "Giao Duc", 25_000),
                new SachThamKhao("STK03", new DateTime(2023, 6, 30), 45_000, 60, "Kim Dong", 10_000)
            };
            foreach (Sach sach in danhSachSach)
            {
                danhSach.Them(sach);
            }
            bool tiepTuc = true;

            while (tiepTuc)
            {
                HienThiMenu();

                Console.Write("Chon chuc nang: ");
                string luaChon = Console.ReadLine() ?? "";

                switch (luaChon)
                {
                    case "1":
                        Console.WriteLine(
                            "\n===== DANH SACH TAT CA SACH =====");

                        Console.Write(danhSach.ToString());

                        break;


                    case "2":
                        Console.WriteLine(
                            $"\nTong thanh tien sach giao khoa: " +
                            $"{danhSach.TinhTongThanhTienSGK():N0} d");

                        break;


                    case "3":
                        Console.WriteLine(
                            $"\nTong thanh tien sach tham khao: " +
                            $"{danhSach.TinhTongThanhTienSTK():N0} d");

                        break;


                    case "4":
                        Console.Write("\nNhap ten nha xuat ban can tim: ");

                        string nxb = Console.ReadLine() ?? "";

                        List<Sach> ketQua =
                            danhSach.TimSachGiaoKhoaTheoNXB(nxb);

                        if (ketQua.Count == 0)
                        {
                            Console.WriteLine(
                                "Khong tim thay sach giao khoa nao " +
                                "cua nha xuat ban nay.");
                        }
                        else
                        {
                            Console.WriteLine(
                                $"\nSach giao khoa cua NXB \"{nxb}\":");

                            foreach (Sach sach in ketQua)
                            {
                                Console.WriteLine(sach);
                            }
                        }

                        break;


                    case "5":
                        Console.WriteLine(
                            $"\nThanh tien cao nhat: " +
                            $"{danhSach.TimThanhTienCaoNhat():N0} d");

                        break;


                    case "0":
                        tiepTuc = false;

                        Console.WriteLine(
                            "Da thoat chuong trinh.");

                        break;


                    default:
                        Console.WriteLine(
                            "Lua chon khong hop le, vui long chon lai.");

                        break;
                }

                Console.WriteLine();
            }
        }


        static void HienThiMenu()
        {
            Console.WriteLine("========== MENU QUAN LY SACH ==========");
            Console.WriteLine("1. Hien thi danh sach sach");
            Console.WriteLine("2. Tinh tong thanh tien sach giao khoa");
            Console.WriteLine("3. Tinh tong thanh tien sach tham khao");
            Console.WriteLine("4. Tim sach giao khoa theo nha xuat ban");
            Console.WriteLine("5. Tim thanh tien cao nhat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("=======================================");
        }

    }
}


