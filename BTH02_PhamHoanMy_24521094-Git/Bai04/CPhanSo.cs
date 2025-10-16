using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class CPhanSo
    {
        private int tu;
        private int mau;

        public CPhanSo(int tuSo = 0, int mauSo = 1)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số phải khác 0.");
            }
            tu = tuSo;
            mau = mauSo;
            RutGon();
        }
        private void RutGon()
        {
            if (tu == 0)
            {
                mau = 1;
                return;
            }

            int UCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (b != 0) { int temp = b; b = a % b; a = temp; }
                return a;
            }

            int uocChung = UCLN(tu, mau);
            tu /= uocChung;
            mau /= uocChung;

            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        public override string ToString()
        {
            if (mau == 1) return $"{tu}";
            return $"{tu}/{mau}";
        }

        public static CPhanSo operator +(CPhanSo a, CPhanSo b)
            => new CPhanSo(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);

        public static CPhanSo operator -(CPhanSo a, CPhanSo b)
            => new CPhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);

        public static CPhanSo operator *(CPhanSo a, CPhanSo b)
            => new CPhanSo(a.tu * b.tu, a.mau * b.mau);

        public static CPhanSo operator /(CPhanSo a, CPhanSo b)
        {
            if (b.tu == 0) throw new DivideByZeroException("Không thể chia cho phân số 0.");
            return new CPhanSo(a.tu * b.mau, a.mau * b.tu);
        }

        public static bool operator >(CPhanSo a, CPhanSo b)
            => a.tu * b.mau > b.tu * a.mau;

        public static bool operator <(CPhanSo a, CPhanSo b)
            => a.tu * b.mau < b.tu * a.mau;
    }
}