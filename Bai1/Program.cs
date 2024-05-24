using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5};
            Console.WriteLine("Cac so le co trong danh sach: ");
            var odd = num.FindAll(numbers => numbers % 2 != 0);
            foreach (int i in odd)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
