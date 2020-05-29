using System;

namespace Ex9
{
    class StudentWorker : Human, IWorker, IStudent
    {
        public StudentWorker(string lastname) : base(lastname)
        {

        }
        public void Pay(int sum)
        {
            Console.WriteLine($"{this.Lastname} has to pay: {sum}");
        }

        public void Salary(int sum)
        {
            Console.WriteLine($"{this.Lastname} has to earn: {sum}");
        }
    }
}
