
using System.Diagnostics.Contracts;

namespace Semana15
{
    public class Corea
    {
        // Propiedades
        string valor1;
        int valor2;
        int valor3;
        public static void Main()
        {
            bool salir = false;
            Corea objetoProgram = new Corea(" ", 0, 0);
            do
            {
                string menu = Console.ReadLine();
                // Declara como int para que valide posteriormente
                int opcion;

                Console.WriteLine("Bienvenido \n Teclee '1', '2' o'3' para seleccionar una opción");
                Console.WriteLine("1. Ingresar valores \n2. Mostrar valores \n3. Salir del programa");
                if(!int.TryParse(menu, out opcion))
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
                }
                switch(opcion)
                {
                    case 1:
                    objetoProgram.leer();      
                    break;
                    case 2:
                    objetoProgram.show();
                    break;
                    case 3:
                    salir = true;
                    break;
                }
                }
                while(!salir);
        }

        public void leer()
        {
            Console.WriteLine("Ingrese su nombre");
                valor1 = Console.ReadLine(); 

                Console.WriteLine("Ingrese su edad");
                valor2 = Int32.Parse(Console.ReadLine()); 

                Console.WriteLine("Ingrese su número preferido");
                valor3 = Int32.Parse(Console.ReadLine()); 

        }
        Corea(string valor1, int valor2, int valor3)
        {
            this.valor1 = valor1; 
            this.valor2 = valor2;
            this.valor3 = valor3;
        }
        // metodos de la clase

        void show()
        {
            Console.WriteLine(this.valor1);
            Console.WriteLine(this.valor2);
            Console.WriteLine(this.valor3);
        }
}
}