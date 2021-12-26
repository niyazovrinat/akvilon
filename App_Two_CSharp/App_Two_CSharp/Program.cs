using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Two_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# Two: " + App_One_CSharp.ClassTest.GetTest());
            Console.Read();
        }
    }
}
