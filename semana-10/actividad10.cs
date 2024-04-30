namespace Sophia_Corea1185324
{
    public class actividad10
    {
        public int CalcularFactorial(int numero)
        {
 
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
        }
    class Principal : actividad10
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Ingresa un valor ");
            int numero = Int32.Parse(Console.ReadLine());
            actividad10 operacion = new actividad10(); // "new" convierte la clase en objeto
            int resultado = operacion.CalcularFactorial(numero); // se le asgina el método creado en la public class


            Console.WriteLine("El factorial de " + numero + " es "+ resultado); 
        }
    }
    }
