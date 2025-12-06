using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Counter("Счётчик", 10);
            c = c + 5;
            Console.WriteLine(c);
            c["value"] = 20;
            Console.WriteLine(c);
        }
    }
    class Counter
    {
        private string name;
        private int value;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public Counter(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public static Counter operator +(Counter counter, int inc)
        {
            return new Counter(counter.Name, counter.Value + inc);
        }
        public int this[string index]
        {
            get
            {
                return Value;
            }
            set
            {
                if (index == "value")
                {
                    Value = value;
                }
                else
                {
                    Console.WriteLine("Невреный индекс");
                }
            }
        }
        public override string ToString()
        {
            return Name + ": " + Value;
        }
    }
}
