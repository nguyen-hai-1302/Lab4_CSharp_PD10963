using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class UserData
    {
        public string Name;
        public int Level;
        public UserData (string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserData> list = new List<UserData>();
            list.Add(new UserData("CBS", 300));
            list.Add(new UserData("Angel", 500));
            list.Add(new UserData("Lucky Boy", 250));
            list.Add(new UserData("SeaKun", 400));
            var select = list.Select(x => new { x.Name, x.Level });
            Console.WriteLine("Thong tin danh sach: ");
            foreach (var item in select)
            {
                Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
            }
            var Descending = list.OrderByDescending(y => y.Level);
            Console.WriteLine("Danh sach Level giam dan");
            foreach (var item in Descending)
            {
                Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
            }
            Console.ReadLine();
        }
    }
}
