
namespace Bai3Module3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.OutputEncoding = System.Text.Encoding.UTF8;
             Console.InputEncoding = System.Text.Encoding.UTF8;
            
             // Tạo sẵn mỗi loại 3 giao dịch
             List<GiaoDichVang> dsVang = new List<GiaoDichVang>
             {
                 new GiaoDichVang("GDV01", new DateTime(2026, 1, 10), 7_500_000, 5, "SJC"),
                 new GiaoDichVang("GDV02", new DateTime(2026, 2, 14), 7_400_000_000, 10, "Nhẫn 9999"),
                 new GiaoDichVang("GDV03", new DateTime(2026, 3, 18), 7_600_000, 20, "SJC"),
             };
            
             List<GiaoDichTienTe> dsTienTe = new List<GiaoDichTienTe>
             {
                 new GiaoDichTienTe("GDT01", new DateTime(2026, 1, 5), 1, 50_000_000, 25_400, LoaiTienTe.USD),
                 new GiaoDichTienTe("GDT02", new DateTime(2026, 2, 8), 1, 20_000_000, 27_500, LoaiTienTe.EURO),
                 new GiaoDichTienTe("GDT03", new DateTime(2026, 3, 12), 1, 100_000_000, 1, LoaiTienTe.VND),
             };
             double tongSoLuongVang = 0;
            
             foreach (var gd in dsVang)
             {
                 tongSoLuongVang += gd.SoLuong;
             }
            
             double tongSoLuongTienTe = 0;
            
             foreach (var gd in dsTienTe)
             {
                 tongSoLuongTienTe += gd.SoLuong;
             }
             Console.WriteLine("Tổng số lượng vàng     : " + tongSoLuongVang.ToString("N0"));
             Console.WriteLine("Tổng số lượng tiền tệ  : " + tongSoLuongTienTe.ToString("N0"));
              
             // Trung bình thành tiền
             decimal tongThanhTienTienTe = 0;
            
             foreach (GiaoDichTienTe gd in dsTienTe)
             {
                 tongThanhTienTienTe += gd.ThanhTien();
             }
            
             decimal trungBinhThanhTien = tongThanhTienTienTe / dsTienTe.Count;
             Console.WriteLine("Trung bình thành tiền tiền tệ: " + trungBinhThanhTien.ToString("N0"));
            
             Console.WriteLine("Các giao dịch có đơn giá > 1 tỷ.");
             bool coGiaoDich = false;
             // Kiểm tra giao dịch vàng
             foreach (GiaoDichVang gd in dsVang)
             {
                 if (gd.DonGia > 1_000_000_000)
                 {
            
                     Console.WriteLine(gd.ToString());
                     coGiaoDich = true;
                 }
             }
            
             // Kiểm tra giao dịch tiền tệ
             foreach (GiaoDichTienTe gd in dsTienTe)
             {
                 if (gd.DonGia > 1_000_000_000)
                 {
                     Console.WriteLine(gd.ToString());
                     coGiaoDich = true;
                 }
             }
             if (!coGiaoDich)
             {
                 Console.WriteLine("Không có giao dịch nào.");
             }                    
        }
    }
}
        
        
    
