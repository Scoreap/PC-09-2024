namespace semana_12
{
    class Actividad
    {
        static void Main(string[] args)
        {
            menu();
        }
 
        static void menu()
        {
            Console.WriteLine("Semana 12");
            Console.WriteLine(" a) Multiplicación");
            Console.WriteLine(" b) Suma");
            Console.WriteLine(" c) Resta ");
 
            char opcion = Console.ReadLine().ToLower()[0];
            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un número para multiplicar");
                    int aMult = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("Ingrese el segundo valor");
                    int bMult = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("El resultado es : " + Multiplicacion(aMult, bMult));
                    Console.ReadKey();
 
                    break;
                
                case 'b':
                    Console.WriteLine("Ingrese un número para sumar");
                    int aSum = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("Ingrese el segundo valor");
                    int bSum = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("El resultado es: " + Suma(aSum, bSum));
                    Console.ReadKey();
 
                    break;
                
                case 'c':
                    Console.WriteLine("Ingrese un número para restar");
                    int aRest = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("Ingrese el segundo valor");
                    int bRest = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("El resultado es: " + Suma(aRest, bRest));
                    Console.ReadKey();
 
                    break;
 
                default:
                    Console.WriteLine("La opción seleccionada no es válida.");
                    break;
            }
        }
 
        //envio de parámetros
        public static int Multiplicacion(int a, int b)
        {
            int resultado = 0;
            resultado = a * b;
            return resultado;
        }
        public static int Suma(int a, int b)
        {
            int resultado = 0;
            resultado = a + b;
            return resultado;
        }
        public static int Resta(int a, int b)
        {
            int resultado = 0;
            resultado = a - b;
            return resultado;
        }
 
    }
}