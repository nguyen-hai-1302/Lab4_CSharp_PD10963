using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Students
    {
        public string ID;
        public string Name;
        public int Age;
        public Students(string id, string name, int age) 
        { 
            ID = id;
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(new Students("PD1", "Anh", 12));
            students.Add(new Students("PD2", "Bao", 20));
            students.Add(new Students("PD3", "Chinh", 22));
            students.Add(new Students("PD4", "Dung", 15));
            students.Add(new Students("PD5", "Hoang", 10));
            students.Add(new Students("PD6", "Giang", 19));
            var AGE = from a in students
                      where a.Age > 12 && a.Age < 20
                      select a;
            Console.WriteLine("LINQ Query Syntax: ");
            foreach (var student in AGE)
            {
                Console.WriteLine("ID: " + student.ID + " | Name: " + student.Name + " | Age: " + student.Age);
            }
            var AGE1 = students.Where(a => a.Age > 12 && a.Age < 20);
            Console.WriteLine("LINQ Method Syntax: ");
            foreach (var student in AGE1)
            {
                Console.WriteLine("ID: " + student.ID + " | Name: " + student.Name + " | Age: " + student.Age);
            }
            Console.ReadLine();
        }
    }
}
