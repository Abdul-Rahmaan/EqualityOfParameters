using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersEquality
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = "A";
            string b = "A";

            Console.WriteLine("Original values: " + a + ", " + b );
            Console.WriteLine("Check the equality values: " + test(a, b) +"\n");
            
            int c = 20;
            string d = "20";

            Console.WriteLine("Original values: " + c + ", " + d);
            Console.WriteLine("Check the equality values: " + test(c, d) + "\n");

            bool e = true;
            bool f = true;

            Console.WriteLine("Original values: " + e + ", " + f);
            Console.WriteLine("Check the equality values: " + test(e, f) + "\n");

        }

        public static bool test(object x, object y)
        {
            if (!x.Equals(y))
            {
                 return false;
            }

            if (!x.GetType().Equals(y.GetType()))
            {
                return false;
            }
            return true;
        }
    }
}
