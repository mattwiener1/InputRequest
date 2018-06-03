using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InputRequest
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] valid = new int[11] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("Please neter a number between 0 and 10");
            var result = Console.ReadLine();

            Console.WriteLine(result);

            switch (result)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    Console.WriteLine("This is a valid entry");
                    break;
                default:
                    Console.WriteLine("This is not a valid entry");
                    break;
                
            }

        }
    }
}
