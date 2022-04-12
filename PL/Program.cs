using System;
using System.IO;
namespace PL
{
    class Program
    {
        public static int LeerArchivo()
        {
            string text = File.ReadAllText(@"C:\ArchivosPrueba\Test.txt");
            Console.WriteLine(text);

            string[] palabras=text.Split('|');

            using (StreamReader file = new StreamReader(text))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
            }
            

            return 5;
        }


        public static void EscribirArchivo(int palabrasDeseadas)
        {
            string texto = "";
            
            
            File.WriteAllText(@"C:\ArchivosPrueba\NuevoMensaje.txt", texto);
        }
        static void Main(string[] args)
        {
            int palabrasDeseadas=LeerArchivo();

            EscribirArchivo(palabrasDeseadas);

            PL.Materia.Add();
          //  BL.Materia.GetAll();
            //BL.Materia.GetById(1);

            //PL.Materia.Add();
            Console.WriteLine("Hello World!");
        }
    }
}
