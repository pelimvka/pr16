using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);
        }
    }
    class Vector
    {
        private double[] count;

        public Vector(params double[] count)
        {
            this.count = count;
        }
        public static double operator *(Vector a, Vector b)
        {
            if (a.count.Length != b.count.Length)
            {
                Console.WriteLine("mistakes1");
            }
            double result = 0;
            for (int i = 0; i < a.count.Length; i++)
            {
                result += a.count[i] * b.count[i];
            }
            return result;
        }
        public double this[int index]
        {
            get { return 0; }
            set
            {
                if (index >= 0)
                {
                    count[index] = value;
                }
                else
                {
                    Console.WriteLine("mistakes3");
                }
            }
        }
        public override string ToString()
        {
            return "[" + string.Join(", ", count) + "]";
        }
    }
}
