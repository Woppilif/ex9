using Ex9.Identity;

namespace Ex9
{
    abstract class Human : IHuman
    {
        public string Lastname { get; set; }

        public Human(string lastname)
        {
            Lastname = lastname;
        }
    }
}
