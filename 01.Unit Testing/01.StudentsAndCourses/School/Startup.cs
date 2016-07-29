namespace School
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            var pesho = new Student("pesho");

            Console.WriteLine(pesho.ID);
        }
    }
}
