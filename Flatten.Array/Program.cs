using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatten.Array
{
    class Program
    {
        static List<object> finalArray;
        static void Main(string[] args)
        {
            var arrayDemo = new object[] { 1, 2, new object[] { 3,5,7 }, 4, new object[] { } };
            var resolveArray = new ArrayTransform();

            resolveArray.SolveArray(arrayDemo);

            resolveArray.FinalArray.ForEach(e =>
            {
                Console.WriteLine(e);
            });
            Console.ReadKey();
        }

     
    }
}
