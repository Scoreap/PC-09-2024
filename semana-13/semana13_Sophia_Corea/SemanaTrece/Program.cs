using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace SemanaTrece
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[8];
            int num = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingrese 8 dígitos enteros");
                num = Int32.Parse(Console.ReadLine());
                
                arreglo1[i] = num;
    
            }
            Console.WriteLine("Los dígitos ingresados son: ");
            foreach(int d in arreglo1)
            {
                Console.WriteLine(d);
            
            }
            int suma = 0;
            for(int i = 0; i < 8; i++ )
            {
            
                suma = arreglo1[i] + suma;

            }
            Console.WriteLine("La suma de los dígitos es: " + suma);

            int promedio = suma / arreglo1.Length;
            Console.WriteLine("El promedio es: " + promedio);
            
    }
}
}