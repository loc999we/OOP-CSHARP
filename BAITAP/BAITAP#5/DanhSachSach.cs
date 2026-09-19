using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Module3
{
    internal class DanhSachSach
    {
        private Sach[] list;
        private int count;

        public DanhSachSach(int soLuong)
        {
            list = new Sach[soLuong];
            count = 0;
        }

        public bool Them(Sach sach)
        {
            if (count >= list.Length)
            {
                return false;
            }

            if (sach == null)
            {
                return false;
            }

            list[count] = sach;
            count++;

            return true;
        }

        public double TinhTongThanhTienSGK()
        {
            double tong = 0;

            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachGiaoKhoa)
                {
                    tong += list[i].TinhThanhTien();
                }
            }

            return tong;
        }

        public double TinhTongThanhTienSTK()
        {
            double tong = 0;

            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachThamKhao)
                {
                    tong += list[i].TinhThanhTien();
                }
            }

            return tong;
        }

        public List<Sach> TimSachGiaoKhoaTheoNXB(string nhaXuatBan)
        {
            List<Sach> ketQua = new List<Sach>();

            for (int i = 0; i < count; i++)
            {
                if (list[i] is SachGiaoKhoa
                    && list[i].NhaXuatBan.Equals(
                        nhaXuatBan,
                        StringComparison.OrdinalIgnoreCase))
                {
                    ketQua.Add(list[i]);
                }
            }
            return ketQua;
        }

        public double TimThanhTienCaoNhat()
        {
            if (count == 0)
            {
                return 0;
            }

            double max = list[0].TinhThanhTien();

            for (int i = 1; i < count; i++)
            {
                if (list[i].TinhThanhTien() > max)
                {
                    max = list[i].TinhThanhTien();
                }
            }

            return max;
        }

        public override string ToString()
        {
            string ketQua = "";

            for (int i = 0; i < count; i++)
            {
                ketQua += list[i].ToString() + Environment.NewLine;
            }

            return ketQua;
        }
    }
}
