using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintedEdition printededition = new PrintedEdition("черная", " печать ", "бумага ");
            Newspaper newspaper = new Newspaper("черная-цветная", " цифровая печать ", "полиграфическая ", "бумага");
            Book book = new Book("черная-цветная", " Верстка ", " войлок ", "сушка под прессом");
            Periodicals periodicals = new Periodicals("черная-цветная", " печать ", " войлок ", "очень низкая ");

            Console.WriteLine(printededition.ToString());
            Console.WriteLine(newspaper.ToString());
            Console.WriteLine(book.ToString());
            Console.WriteLine(periodicals.ToString());

            Console.ReadKey();
        }
    }
}
