using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_30
{
    public class CycleList
    {
        private class Point
        {
            public int Data { get; set; }
            public Point Next { get; set; }
        }

        Point _beg;
        Point _last;

        public void Add(int element)
        {
            Point p = new Point();
            p.Data = element;

            if (_beg == null)
            {
                _beg = p;
                _last = p;
                p.Next = p;
            }
            else
            {
                _last.Next = p;
                _last = p;
                p.Next = _beg;
            }
        }

        public void Show()
        {
            Point p = _beg;
            do
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
            while (p != _beg);

            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;

            Point p = _beg;
            do
            {
                sum += p.Data;
                p = p.Next;
            }
            while (p != _beg);

            return sum;
        }

        public int SumRecursive()
        {
            return Sum(_beg.Next);
        }

        private int Sum(Point p)
        {
            if (p == _beg)
                return p.Data;

            return p.Data + Sum(p.Next);
        }
    }
}
