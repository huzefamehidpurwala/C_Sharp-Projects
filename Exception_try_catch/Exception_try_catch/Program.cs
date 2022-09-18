using System;

namespace Exception_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            //c = 23 / a;
            try
            {
                c = 23 / a;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Go to hell!!");
            }
        }
    }
}
