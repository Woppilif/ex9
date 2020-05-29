using System;

namespace Ex9
{
    class Student : Human, IStudent
    {
        public Student(string lastname) : base(lastname)
        {
        }

        public void Pay(int sum)
        {
            Console.WriteLine($"{this.Lastname} has to pay: {sum}");
        }
    }
}
