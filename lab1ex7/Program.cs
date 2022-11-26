using System;

namespace lab1ex7
{
    /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program verifica daca numarul citit este par sau impar. \n");

            Console.WriteLine("Introduceti un numar:");
            var nr = int.Parse(Console.ReadLine());

            if (nr % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");

        }
    }
}
