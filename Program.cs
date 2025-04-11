using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
  namespace Mcode
  {
    
    class Pratices{   
           public static void Main(string[] args){
            int a,b;

            System.Console.WriteLine("Enter the value of a & b :");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"The sum of {a} and {b} is {a+b}");

           Console.ReadKey();   
           }
    }
  }
