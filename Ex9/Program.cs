using System;
using Ex6V10;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayContainer arrayContainer = new ArrayContainer();

            arrayContainer.Add(new Student("Kozin Jr"));
            arrayContainer.Add(new Worker("Mr.Kozin"));
            arrayContainer.Add(new StudentWorker("Mr.Kozin I"));

            arrayContainer.Out();
            string input = Console.ReadLine();

            switch (input)
            {
                ""
                default:
                    break;
            }
        }
    }
}
