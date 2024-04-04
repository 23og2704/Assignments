using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter your first number: ");    
            num1 = int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter your second number: ");
            num2 = int.Parse(Console.ReadLine());  
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);
            num3 = num1 + num2;
            Console.WriteLine(num3 * num3);
            Console.ReadKey();

            int slaba;
            int slabd;
            float slabp;
            int slabamount;
            float price;
            string fCost;
            Console.WriteLine("Enter number of slabs across: ");
            slaba = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of slabs deep: ");
            slabd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of slab: ");
            slabp = float.Parse(Console.ReadLine());  
            slabamount = slaba * slabd; 
            price = slabp * slabamount;
            fCost = price.ToString("C2", CultureInfo.GetCultureInfo("en-GB"));
            Console.WriteLine($"Total price is: {fCost}");
            Console.ReadKey();
        }
    }
}
