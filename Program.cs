using System;

namespace ytubetutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting variables and differences in int and byte
            int i = 1000;
            byte b = (byte) i;
            System.Console.WriteLine(b);
            
            // Try and catch examples
            try
            {
                string number = "1234";
                int j = Convert.ToByte(number);
                System.Console.WriteLine(j);
            }
            catch (Exception)
            {
                System.Console.WriteLine("the number could not be converted to a byte!");
            }

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                System.Console.WriteLine(c);
            }
            catch (Exception)
            {
                System.Console.WriteLine("the number could not be converted to a boolean value!");
            }

            // Operator examples
            var y = 10;
            var z = 3;
            
            System.Console.WriteLine((float)y / (float)z);
            System.Console.WriteLine(y > z);
            System.Console.WriteLine(y == z);
            System.Console.WriteLine(y != z);

            var l = 1;
            var k = 2;
            var m = 3;

            System.Console.WriteLine(l + k * m);
            System.Console.WriteLine(m > k && m > l);
            System.Console.WriteLine(m > k && m == l);
            System.Console.WriteLine(m > k || m == l);
        }
    }
}
