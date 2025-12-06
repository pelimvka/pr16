using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book[0] = "Введение";
            book[1] = "Глава 1";
            Console.WriteLine(book[0]);
            Console.WriteLine(book);

        }
    }
    class Book
    {
        private string[] chapters = new string[50];
        private int chaptCounter = 0;
        public string this[int index]
        {
            get 
            {
                return chapters[index]; 
            }
            set
            {
                if (index < 0 || index > chapters.Length)
                {
                    Console.WriteLine("Индекс находится вне диапазона (0 - 50)!");
                } else
                {
                    chapters[index] = value;
                }
                if (index >= chaptCounter)
                    chaptCounter = index + 1;
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < chaptCounter; i++)
            {
                result += $"{i + 1}. {chapters[i]}\n";
            }
            return result;
        }
    }
}
