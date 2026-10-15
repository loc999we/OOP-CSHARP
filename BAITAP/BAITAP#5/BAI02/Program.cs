using static System.Reflection.Metadata.BlobBuilder;

namespace Bai2Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Sach> dsSach = new List<Sach>()
            {
                new SachGiaoKhoa(TinhTrang.Cu,"SGK01",new DateTime(2026,12,5),50000,200,"Kim Đồng"),
                new SachGiaoKhoa(TinhTrang.Cu,"SGK02",new DateTime(2026,11,5),55000,180,"Tuổi Trẻ"),
                new SachGiaoKhoa(TinhTrang.Moi,"SGK03",new DateTime(2026,10,5),55000,180,"UEH"),
            
                new SachThamKhao(10/100,"STK01",new DateTime(2026,9,5),55000,180,"UEH"),
                new SachThamKhao(15/100,"STK02",new DateTime(2026,9,5),45000,100,"Kim Đồng"),
                new SachThamKhao(12/100,"STK03",new DateTime(2026,9,5),50000,120,"Tuổi Trẻ"),
            };
            
            // Thành Tiền Cho Từng Loại
            double tienSGK = 0;
            double tienSTK = 0;
            foreach (Sach s in dsSach)
            {
                tienSGK += s.ThanhTien();
                tienSTK += s.ThanhTien();
            }
            Console.WriteLine("Thành Tiền SGK:"+tienSGK);
            Console.WriteLine("Thành Tiền STK:" + tienSTK);
            
            Console.WriteLine("Nhập tên NXB:");
            
            string nxb = Console.ReadLine();
            foreach (Sach x in dsSach)
            {
                if (x.NhaXuatBan.Equals (nxb,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(x.ToString());
                }
            }
        }
    }
}


