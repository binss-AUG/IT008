using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class LCPhanso
    {
        private List<CPhanSo> danhSach;

        public LCPhanso()
        {
            danhSach = new List<CPhanSo>();
        }

        public void Nhap()
        {
            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"---Nhập phân số thứ {i + 1}---");
                Console.Write("Tử số: ");
                int tu = int.Parse(Console.ReadLine());
                Console.Write("Mẫu số: ");
                int mau = int.Parse(Console.ReadLine());
                danhSach.Add(new CPhanSo(tu, mau));
            }
        }

        public void Xuat()
        {
            foreach (var ps in danhSach)
            {
                Console.Write(ps + "  ");
            }
            Console.WriteLine();
        }

        public CPhanSo TimMax()
        {
            if (danhSach.Count == 0)
            {
                throw new InvalidOperationException("Danh sách rỗng, không thể tìm max.");
            }

            CPhanSo max = danhSach[0];
            foreach (var ps in danhSach)
            {
                if (ps > max) 
                {
                    max = ps;
                }
            }
            return max;
        }

        public void SapXepTangDan()
        {
            for (int i = 0; i < danhSach.Count - 1; i++)
            {
                for (int j = 0; j < danhSach.Count - 1 - i; j++)
                {
                    if (danhSach[j] > danhSach[j + 1])
                    {
                        var temp = danhSach[j];
                        danhSach[j] = danhSach[j + 1];
                        danhSach[j + 1] = temp;
                    }
                }
            }
        }
    }
}
