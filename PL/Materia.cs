using System;
using System.Collections.Generic;
using System.Text;

namespace PL
{
    public class Materia
    {
        public static void Add()
        {
            
            ML.Materia materia = new ML.Materia();
            
            Console.WriteLine("Nombre");
            materia.Nombre = Console.ReadLine();

            Console.WriteLine("Descripcion");
            materia.Descripcion = Console.ReadLine();

            Console.WriteLine("Creditos");
            materia.Creditos = byte.Parse(Console.ReadLine());

            ML.Result result = BL.Materia.Add(materia);


        }
    }
}
