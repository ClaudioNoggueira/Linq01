using System;
using System.Linq;

namespace Linq01 {
    class Program {
        static void Main(string[] args) {

            //Specify the data source
            int[] numbers = new int[] { 3, 4, 5, 6 };

            //Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach (int item in result) {
                Console.WriteLine(item);
            }
        }
    }
}
