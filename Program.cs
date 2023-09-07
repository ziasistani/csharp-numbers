using System;
using System.Data;
using System.Diagnostics;

namespace decimal_double
{
    class Program
    {
        static private int iterations = 100000000;

        static void Main(string[] args)
        {
            Console.Clear();
            SingleAddition();
            DoubleAddition();
            DecimalAddition();
            SingleSpeed();
            DoubleSpeed();
            DecimalSpeed();
            Console.WriteLine("r\n\r\n\r\n\r\n\r\n");
        }

        static public void SingleAddition ()
        {
            Single x = 0.1f;
            Single result = 10 * x;
            Single result2 = x + x + x + x + x + x + x + x + x + x;
            Console.Write("\r\n\r\n\r\n#### Single Addition #### \r\n 10 * 0.1 =");
            Console.ReadKey();
            Console.Write("{0:R}\r\n" , result);
            Console.Write("\r\n 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 =" );
            Console.ReadKey();
            Console.Write("{0:R} \r\n ", result2);
            Console.ReadKey();
        }
        
        static public void DoubleAddition()
        {
            Double x = 0.1;
            Double result = 10 * x;
            Double result2 = x + x + x + x + x + x + x + x + x + x;
            Console.Write("\r\n\r\n\r\n#### Double Addition #### \r\n 10 * 0.1 =");
            Console.ReadKey();
            Console.Write("{0:R}\r\n" , result);
            Console.Write("\r\n 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 =" );
            Console.ReadKey();
            Console.Write("{0:R} \r\n ", result2);
            Console.ReadKey();
        }
        static public void DecimalAddition()
        {
            Decimal x = 0.1M;
            Decimal result = 10 * x;
            Decimal result2 = x + x + x + x + x + x + x + x + x + x;
            Console.Write("\r\n\r\n\r\n#### Decimal Addition #### \r\n 10 * 0.1 =");
            Console.ReadKey();
            Console.Write("{0:R}\r\n" , result);
            Console.Write("\r\n 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 =" );
            Console.ReadKey();
            Console.Write("{0:R} \r\n ", result2);
            Console.ReadKey();
        }
        
        static private void SingleSpeed()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Single z = 0;
            for (int i = 0; i < iterations; i++)
            {
                //Single x = i;
                z += 0.001f;
            }
            watch.Stop();
            Console.Write("\r\n\r\n\r\n\r\n\r\n\r\n100 Million Single operation takes : " + watch.ElapsedTicks/1000000+ " Seconds\t");
            Console.WriteLine("sum={0:R}",z*1000);
            Console.ReadKey();
        }

        static private void DoubleSpeed()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Double z = 0;
            for (int i = 0; i < iterations; i++)
            {
                //Double x = i;
                //Double y = x * i;
                z += 0.001;
            }
            watch.Stop();
            Console.Write("\r\n100 Million Double operation takes : " + watch.ElapsedTicks/1000000+ " Seconds\t");
            Console.WriteLine("sum={0:R}",z*1000);
            Console.ReadKey();
        }

        static private void DecimalSpeed()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Decimal z = 0;
            for (int i = 0; i < iterations; i++)
            {
                //Decimal x = i;
                //Decimal y = x * i;
                z += 0.001M;
            }
            watch.Stop();
            Console.Write("\r\n100 Million Decimal operation takes:" + watch.ElapsedTicks/1000000+" Seconds\t");
            Console.WriteLine("sum={0:R}",z*1000);
            Console.ReadKey();
        }
       
        static public void DoubleAdditionCorrect()
        {
            Double x = .1;
            Double result =0;
            for (int i = 1; i <= 10; i++) result += 10*x;
            Double result2 = 0;
            for(int i=1;i<=100;i++) result2+=x;
            Console.WriteLine("x={0:R}", x);
            Console.WriteLine("result={0}   \t result2={1}", result, result2);
            Console.WriteLine("result={0:R} \t result2={1:R}", result, result2);
            Console.ReadLine();
        }


    }
}
