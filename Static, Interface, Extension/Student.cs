using Static__Interface__Extension.HelperExtensıon;

namespace Static__Interface__Extension
{
    internal class Student
    {
        static int Count = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            //Name = Helper.Capitalize(name);
            Name = name.Capitalaize();
            Surname = surname.Capitalaize();
            Count++;
            Id = Count;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname}");
        }
    }
}
