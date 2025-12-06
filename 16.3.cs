using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Temperature(25);
            var t2 = new Temperature(30);
            Console.WriteLine(t1);
            Console.WriteLine(t2 > t1);
            Console.WriteLine(t1 == new Temperature(25));

        }
    }
    class Temperature
    {
        private int degrees;
        public int Degrees
        {
            get {  return degrees; }
            set { degrees = value; }
        }
        public Temperature(int degrees)
        {
            Degrees = degrees;
        }
        public static bool operator >(Temperature left, Temperature right)
        {
            return left.Degrees > right.Degrees;
        }
        public static bool operator <(Temperature left, Temperature right)
        {
            return left.Degrees < right.Degrees;
        }
        public static bool operator ==(Temperature left, Temperature right)
        {
            return left.Degrees == right.Degrees;
        }
        public static bool operator !=(Temperature left, Temperature right)
        {
            return !(left == right);
        }
        public override string ToString()
        {
            return degrees.ToString();
        }
    }
}
