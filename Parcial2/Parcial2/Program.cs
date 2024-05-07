
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Parcial2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program objeto = new Program();

            Console.WriteLine("Bienvenido. \n A continuación ingrese 10 nombres de alumnos: ");

            string[] nombres = new string[10];
            for (int i = 0; i < nombres.Length; i++)
            {      
                nombres[i] = Console.ReadLine();
            }


            Console.WriteLine("Ingrese las 10 notas de los alumnos");
            int[] notas = new int[10];
            for (int i = 0; i < notas.Length; i++)
            {

                nombres[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Ingrese la opción que desea realizar \n 1. Mostrar notas de aprobados. \n 2. Mostrar notas de reprobados \n 3. Promedio \n 4. Salir ");
            do
            {
                bool Salir = false;
    
                string menu = Console.ReadLine();
                int opcion = 0;
                if (int.TryParse(menu, out opcion))
                {
                    Console.WriteLine("Ingrese un numero entero");
                }

                    switch (opcion)
                    {
                        case 1:
                            foreach(var item in nombres )
                            {
                                Console.WriteLine(item);
                            }
                            foreach(var item in notas )
                            {
                                Console.WriteLine(item);
                            }
    
                            break;
                        case 2:

                            break;
                        case 3:

                            int Suma = notas.Sum();
                            int Promedio = Suma / notas.Length;

                            break;
                        case 4:
                            Salir = true;
                            break;
                        default:
                        Console.WriteLine("Debe ingresar el número que se indica a la par de la opción");
                        break;
                    }
            }
            while (!true);
        }
    }
}