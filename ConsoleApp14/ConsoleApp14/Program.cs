using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary bd = new MyLibrary();

            bd.AddBook(
               new Book("Girl friend remote control", "Will be soon in Amazon...",
               "Aiven Honest", "Fiction"));
            bd.AddBook(
              new Book("Hollerbochen’s Dilemma", "Hollerbochen's Dilemma was poorly received, with Bradbury subsequently writing no one enjoyed my story and I think it was terrible myself...",
               "Ray Bradbury", "Fiction"));
            bd.AddBook(
              new Book("Misery", "After a famous author is rescued from a car crash by a fan of his novels, he comes to realize that the care he is receiving is only the beginning of a nightmare of captivity and abuse....",
               "Stephen King", "Fiction"));

            Console.WriteLine(bd);


        }
    }
}
