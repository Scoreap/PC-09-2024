namespace SemanaTrece
{
    class Program
    {
        // No funcionó
        static void Main(string[] args)
        {
            string[,] arreglo2 = new string[4,4];
            string nombre;
            string apellido;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese hasta 4 nombres: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese los respectivos apellidos: ");
                    apellido = Console.ReadLine();
                    arreglo2[i,j] = nombre;
                }
            Console.WriteLine("Los datos ingresados son: " + arreglo2);
            }
               
            
    }
}
    }
