using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "пирамида";
            Console.WriteLine($"Из слова \"{s}\" получили:");

            var word1 = s
                .Remove(7, 1)   
                .Remove(0, 6)   
                + s.Substring(5, 1)  
                + s.Substring(4, 1)  
                + s.Substring(7, 1); 

            Console.WriteLine(word1);

            var word2 = s
              .Substring(1, 3)  
              + s.Remove(0, 5);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
    }
    
}
