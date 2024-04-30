using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.XPath;

namespace ProgramaCiclos
{
    class Program
    {
        // Definir variables que se utilizarán entre métodos.
        static int suma;
        static int[] numeros = new int[12];
        static int n;
        static void Main(string[]args)
        {
            Program Operaciones = new Program();
            int n = 0;
            bool Salir = false;
            // Guardar numeros en arreglo 
            Console.WriteLine("Ingrese " + numeros.Length + " dígitos: ");
             for (int i = 0; i < numeros.Length ; i++)
             {
                n = Int32.Parse(Console.ReadLine());

                numeros[i] = n;
             }
            do
            {
                // Mostrar opciones
                Console.WriteLine("Bienvenido \n Ingrese el carácter indicado para seleccionar una opción: ");
                Console.WriteLine(" a. Suma \n b. Promedio \n c. Ordenar de menor a mayor \n d. Ordenar de mayor a menor \n e. Añadir dos dígitos \n f. Operador split \n g. Salir");
                string opciones = Console.ReadLine().ToLower();
        
                switch (opciones)
                {
                    case "a":
                    Operaciones.Sum();
                    break;

                    case "b":
                    Operaciones.Promedio();
                    break;
                
                    case "c":
                    Operaciones.MenoraMayor();
                    break;

                    case "d":
                    Operaciones.MayoraMenor();
                    break;
                    case "e":
                    Operaciones.Agregar();
                    break;

                    case "f":
                    Operaciones.Separar();
                    break;
                    case "g":
    
                    Salir = true;
                    Console.WriteLine("El usuario ha salido del programa.");
                    break;

                    default:
                    Console.WriteLine("Opción no válida, intente de nuevo");
                    break;

                }
            }
            while(!Salir);
            
        }
        public void Sum()
        {
            int suma = 0;
                for(int i = 0; i < numeros.Length; i++ )
                {
                    // += permite que no se repita la variable suma de nuevo.
                    suma += numeros[i];
                }
                Console.WriteLine("La suma de los dígitos es: " + suma);
        }
        public void Promedio()
        {
            double promedio;
            suma = numeros.Sum();
            promedio = suma / numeros.Length;

            Console.WriteLine("El promedio de los números es: " + promedio);
        }
        public void MenoraMayor()
        {
            //Utilizar clase Array para añadir el metodo .sort
                Array.Sort(numeros);
                foreach(int digit in numeros )
                {
                    Console.WriteLine(digit);
                }
        }
        public void MayoraMenor()
        {
            // El operador Reverse permite ordenar de mayor a menor.
            Array.Reverse(numeros);
            foreach(var digit in numeros )
            {
                Console.WriteLine(digit);
            }
        }
        public void Agregar()
        {
            Array.Resize(ref numeros, numeros.Length + 2); // Sumar dos espacios al tamaño del arreglo principal
            Console.WriteLine("Añada dos nuevos valores: ");
            numeros[numeros.Length - 2]= Int32.Parse(Console.ReadLine()); // Restar para posicionar el nuevo valor
            numeros[numeros.Length - 1]= Int32.Parse(Console.ReadLine());    
            Console.WriteLine("El nuevo grupo de números es");
       
            foreach(var digit in numeros)
            {
                Console.WriteLine(digit);
            }        
        }
        public void Separar()
        {
            string leerValores = String.Join(",", numeros);
            Console.WriteLine("De esta secuencia de números: " + leerValores);
    
            string[] newNumeros = new string[numeros.Length]; // Crear un nuevo arreglo para usarlo como string.
            
            for (int i = 0; i < numeros.Length; i++)
            {
                newNumeros[i] = numeros[i].ToString(); // Convertir el arreglo principal a string.
            }
            newNumeros = leerValores.Split(',');
            Console.WriteLine("\n Los valores se dividen de esta manera: ");

            // Imprimir el operador .Split
            foreach (string digito in newNumeros)
            {
                Console.WriteLine(digito);
            }
        }
    }
}