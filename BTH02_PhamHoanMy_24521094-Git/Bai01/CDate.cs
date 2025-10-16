using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class CDate
    {
        private int _dd { set; get; }
        private int _mm { set; get; }
        private int _yy { set; get; }
        public int dd
        {
            set { _dd = value; }
            get { return _dd; }
        }
        public int mm
        {
            set { _mm = value; }
            get { return _mm; }
        }
        public int yy
        {
            set { _yy = value; }
            get { return _yy; }
        }
        public CDate(int dd = 1, int mm = 1, int yy = 1)
        {
            this._dd = dd;
            this._mm = mm;
            this._yy = yy;
        }
        private bool isLeap(int yy)
        {
            return ((yy % 4 == 0 && yy % 100 != 0) || (yy % 400 == 0));
        }
        public int thMonth()
        {
            int[] Date = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (isLeap(yy)) Date[2]++;

            return Date[mm];
        }
        public int thDate()
        {

            if (yy <= 0) return 7;
            if (mm < 1 || mm > 12) return 7;
            int[] Date = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (isLeap(yy)) Date[2]++;

            if (dd < 1 || dd > Date[mm]) return 7;

            int SumofDay = 0;

            SumofDay += dd;

            for (int i = 1; i < mm; i++) SumofDay += (Date[i]);

            SumofDay += (yy - 1) + (yy - 1) / 4 - (yy - 1) / 100 + (yy - 1) / 400;

            return SumofDay;
        }
        public int thWeek()
        {
            return this.thDate() % 7;
        }
    }
}
