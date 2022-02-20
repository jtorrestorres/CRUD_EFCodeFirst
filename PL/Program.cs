using System;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            BL.Materia.GetAll();
            BL.Materia.GetById(1);

            //PL.Materia.Add();
            Console.WriteLine("Hello World!");
        }
    }
}
