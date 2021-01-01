using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateRenameTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Making sure a template doesn't already exist...");
            if (File.Exists("template.csv"))
            {
                Console.WriteLine("Found! Delete \"template.csv\" to create a new one.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Done!");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}
