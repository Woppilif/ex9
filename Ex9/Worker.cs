using System;

namespace Ex9
{
    class Worker : Human, IWorker
    {
        public Worker(string lastname) : base(lastname)
        {
        }

        public void Salary(int sum)
        {
            Console.WriteLine($"{this.Lastname} has to earn: {sum}");
        }
    }
}
