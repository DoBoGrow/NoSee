using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int Open { get; set; }

        public Library()
        {
            this.Name = "";
            this.Address = "";
            this.Open = 0;
        }

        public void Input()
        {
            Console.Write("Input name of library: ");
            this.Name = Console.ReadLine();
            Console.Write("Input address of library: ");
            this.Address = Console.ReadLine();
            Console.Write("Input open of library: ");
            this.Open = (int)Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Name: { this.Name }");
            Console.WriteLine("Address: { this.Address }");
            Console.WriteLine("Open: { this.Open }");
        }

        static void Main(string[] args)
        {
            Library q = new Library();
            q.Input();
            q.Print();
            Console.ReadKey();
        }
    }
}