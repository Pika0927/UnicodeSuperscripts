using System;

namespace UnicodeSuperscripts
{
    //Unicode list
    //https://www.asahi-net.or.jp/~ax2s-kmtn/ref/unicode/u2070.html
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("CO\u2082e");//CO2e
            Console.ReadLine();
        }
    }
}
