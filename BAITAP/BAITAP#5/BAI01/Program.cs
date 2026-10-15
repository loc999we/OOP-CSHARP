
namespace Module03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            List <ChuyenXe> dschuyen = new List<ChuyenXe>()
            {
            new ChuyenXeNoiThanh("NT01","Nguyen Van An","59A-12345",500000,5,120),
            new ChuyenXeNoiThanh("NT02","Tran Van Binh","59A-67890",700000,7,180),
            
            new ChuyenXeNgoaiThanh("NG01","Le Van Cuong","51B-11111",1500000,"Vung Tau",2),
            new ChuyenXeNgoaiThanh("NG02","Pham Van Dung","51B-22222",2000000,"Da Lat",3),
            };
            
            // Tính doanh thu
            double tongDoanhThu = 0;
            double dtNoiThanh = 0;
            double dtNgoaiThanh = 0;
            foreach ( var s in dschuyen )
            {
                tongDoanhThu += s.DoanhThu;
                if (s is ChuyenXeNoiThanh) { dtNoiThanh += s.DoanhThu; }
                else if ( s is  ChuyenXeNgoaiThanh) { dtNgoaiThanh += s.DoanhThu; }
            
            }
            // Danh sach chuyến xe
            foreach ( var s in dschuyen)
            {
                Console.WriteLine(s);
            }
            
            // Tinh tổng doanh thu
            Console.WriteLine("TONG DOANH THU TAT CA CHUYEN XE: "+ tongDoanhThu);
            Console.WriteLine("TONG DOANH THU NOI THANH: "+ dtNoiThanh);
            Console.WriteLine("TONG DOANH THU NGOAI THANH: "+ dtNgoaiThanh);
        }
    }
}
