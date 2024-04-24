using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di uno stack di interi
            var intStack = new GenericStack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine(intStack.Peek());  // Stampa: 3
            Console.WriteLine(intStack.Pop());  // Stampa: 3

            // Creazione di uno stack di stringhe
            var stringStack = new GenericStack<string>();
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine(stringStack.Peek());  // Stampa: World
            Console.WriteLine(stringStack.Pop());  // Stampa: World
        }
    }
}
