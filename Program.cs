using System;
using System.Collections;
using System.Linq;
namespace Name
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            List<int> l = new List<int>{1,2,3,4,5};
            var x = l.Where(n=>n>2);
            foreach(var s1 in x){
              Console.WriteLine(s1);
            }
        }
    }




}

