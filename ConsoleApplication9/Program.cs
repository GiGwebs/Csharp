using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Samuel";
            string lastname = "Adjabeng";
            string jointname = "Samuel Adjabeng";
            Console.WriteLine(jointname);
            string nameCAPS = jointname.ToUpper();
            Console.WriteLine(nameCAPS);
            string namesmallcaps = jointname.ToLower();
            Console.WriteLine(namesmallcaps);
            string del = jointname.Substring(7, 4);
            Console.WriteLine(del);
            string[] name = jointname.Split(' ');
            foreach (var item in name)
                Console.WriteLine(item);
        }
    }
}
