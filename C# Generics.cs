using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp19
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person() { Name = "Turan", Surname = "Bayramli", Age = 19 };
            var p2 = new Person() { Name = "Peri", Surname = "Almadatli", Age = 20 };
            var p3 = new Person() { Name = "Guseyn", Surname = "Huseynov", Age = 12 };
            var p4 = new Person() { Name = "Farxad", Surname = "Bayramov", Age = 17 };
            var p5 = new Person() { Name = "Ali", Surname = "Quliyev", Age = 23 };
            var p6 = new Person() { Name = "Turan", Surname = "Dunyamaliyev", Age = 21 };
            var p7 = new Person() { Name = "Fidan", Surname = "Asadova", Age = 18 };
            var p8 = new Person() { Name = "Aydan", Surname = "Bagirli", Age = 25 };
            var p9 = new Person() { Name = "Omar", Surname = "Hasanov", Age = 27 };
            var p10 = new Person() { Name = "Elizabete", Surname = "Nasibova", Age = 24 };

            var people = new List<Person>()
            {
                p1,p2, p3, p4, p5, p6, p7, p8, p9, p10
            };
            Console.WriteLine("Input Name: ");
            string input = Console.ReadLine();
            var result =  people.Find(x => x.Name == input);
            if (result == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Found");
            }
        }
    }
}
