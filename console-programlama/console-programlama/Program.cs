using System;

namespace console_programlama
{
    internal class Program
    {
       public static void Main(string[] args)
        {
           System.Console.WriteLine("Hello World!");
           System.Console.WriteLine("HI!");

            Console.WriteLine("adınızı giriniz:  ");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz:  ");
            string surname = Console.ReadLine();
            Console.WriteLine("teşekkürler, " + " MERHABA " + name + " " + surname + " " + ":) " );

        }
    }
}
