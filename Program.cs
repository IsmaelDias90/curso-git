using System;

namespace projetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;

            Console.WriteLine($"{data.Date.ToString("dd/MM/yyyy")}");
            Console.WriteLine("Hello World!");
        }
    }
}
