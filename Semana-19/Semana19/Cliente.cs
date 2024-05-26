using System.Xml.Serialization;

namespace Semana19;

class Cliente
{
    static PedidoCliente PedidoCliente = new PedidoCliente();
    static List<Restaurante> OrdenCompleta = new List<Restaurante>();
    static string ordenCliente { get; set; }
    static string FormaDePago { get; set; }
    static decimal PrecioPedido { get; set; }

    static void Main(string[] args)
    {
        SeleccionarAccion();
    }
    static void SeleccionarAccion()
    {
        System.Console.WriteLine("Bienvenido\nIndique la opción que desea ejecutar");
        bool Salir = true;
        do
        {
            System.Console.WriteLine("1. Añadir orden\n2. Mostrar Pedidos\n3. Salir");
            string opcionMenu = Console.ReadLine();
            switch (opcionMenu)
            {
                case "1":
                    IngresoDatos();
                    break;

                case "2":
                    PedidoCliente.RegistroPedidos();
                    break;

                case "3":
                    Salir = false;
                    break;

                default:
                    System.Console.WriteLine("Ingrese una opción válida");
                    break;
            }
        }
        while (Salir);

    }
    static void IngresoDatos()
    {
        bool validacionNombre = false;
        while (!validacionNombre)
        {
            try
            {

                System.Console.WriteLine("Ingresar el nombre del cliente");
                string nombreCliente = Console.ReadLine();
                int comprobarNumero = 0;
                if (string.IsNullOrWhiteSpace(nombreCliente) || int.TryParse(nombreCliente, out comprobarNumero))
                {
                    int contadorNombre = 0;
                    do
                    {
                        System.Console.WriteLine("Error.");
                        System.Console.WriteLine("Ingresar nuevamente el nombre del cliente");
                        nombreCliente = Console.ReadLine();
                        int valorNumerico = 0;
                        if (string.IsNullOrWhiteSpace(nombreCliente))
                        {
                            System.Console.WriteLine("");
                        }
                        else if (int.TryParse(nombreCliente, out valorNumerico))
                        {
                            System.Console.WriteLine("Unicamente ingresar cadenas de texto.\n");
                        }
                        /*else if(ValidarEntradaCaracteres(nombreCliente) == true)
                        {
                            System.Console.WriteLine("");
                        }*/
                        else
                        {
                            contadorNombre = 1;
                        }

                    }
                    while (contadorNombre == 0);
                }

                System.Console.WriteLine("Ingresar la orden del cliente");
                MostrarMenu();

                System.Console.WriteLine("Ingresar nota adicional del pedido (opcional) ");
                string notaCliente = Console.ReadLine();

                System.Console.WriteLine("Ingresar método de pago");
                IngresarMetodoDePago();

                //¿Cómo llamar el parámetro de orden aca?
                PedidoCliente.CrearPedido(DateTime.Now, nombreCliente, notaCliente, FormaDePago, PrecioPedido, VerOrdenCompleta());
                PedidoCliente.RegistroPedidos();
                validacionNombre = true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ocurrió una excepción." + e.Message);
            }
        }
    }
    static void MostrarMenu()
    {
        System.Console.WriteLine("Ingresar la opción para seleccionar el pedido del cliente");
        bool validacionMenu = true;
        do
        {
            System.Console.WriteLine("a. Desayuno\nb. Almuerzo\nc. Cena\nd. Bebidas");
            char opcionMenuRestaurante = Console.ReadLine().ToLower()[0];

            if (opcionMenuRestaurante == 'a' || opcionMenuRestaurante == 'b' || opcionMenuRestaurante == 'c' || opcionMenuRestaurante == 'd' || opcionMenuRestaurante == 'e')
            {
                switch (opcionMenuRestaurante)
                {
                    case 'a':
                        ordenCliente = "Desayuno";
                        PrecioPedido += 60;
                        break;
                    case 'b':
                        ordenCliente = "Almuerzo";
                        PrecioPedido += 70;

                        break;
                    case 'c':
                        ordenCliente = "Cena";
                        PrecioPedido += 70;
                        break;
                    case 'd':
                        ordenCliente = "Bebidas";
                        PrecioPedido += 20;
                        break;
                    default:
                        System.Console.WriteLine("Ocurrió un error. Ingresar opción válida");
                        break;
                }

            }
            else
            {
                System.Console.WriteLine("Ingresar una opción válida(a, b o c)");

            }
            if (ordenCliente == "Desayuno" || ordenCliente == "Almuerzo" || ordenCliente == "Cena" || ordenCliente == "Bebidas" || ordenCliente == "Orden Completa")
            {
                var OrdenMenu = new Restaurante(ordenCliente);
                OrdenCompleta.Add(OrdenMenu);
            }
            System.Console.WriteLine("¿Agregar orden adicional? (0 para si, 1 para no)");
            int continueButton = Int32.Parse(Console.ReadLine());
            if (continueButton == 0)
            {
                opcionMenuRestaurante = 'a';
            }
            else
            {
                validacionMenu = false;
            }
        }
        while (validacionMenu);
    }
    static string VerOrdenCompleta()
    {
        var convertirEnTexto = new System.Text.StringBuilder();

        foreach (var item in OrdenCompleta)
        {
            convertirEnTexto.Append(item.OrdenCliente + "\n\t\t\t\t\t\t\t                        ");
        }
        return convertirEnTexto.ToString();
    }

    static void IngresarMetodoDePago()
    {
        try
        {
            System.Console.WriteLine("Seleccionar opción de método de pago");
            bool validacionIngresoPago = true;
            do
            {
                System.Console.WriteLine("a. Efectivo\nb. Transferencia\nc. Pago en línea");
                char opcionIngresoPago = Console.ReadLine().ToLower()[0];

                if (opcionIngresoPago == 'a' || opcionIngresoPago == 'b' || opcionIngresoPago == 'c' || opcionIngresoPago == 'd' || opcionIngresoPago == 'e')
                {
                    switch (opcionIngresoPago)
                    {
                        case 'a':
                            FormaDePago = "Efectivo";
                            validacionIngresoPago = false;
                            break;
                        case 'b':
                            FormaDePago = "Transferencia";
                            validacionIngresoPago = false;

                            break;
                        case 'c':
                            FormaDePago = "Pago en línea";
                            validacionIngresoPago = false;
                            break;
                        default:
                            System.Console.WriteLine("Ocurrió un error. Ingresar opción válida");
                            break;
                    }

                }
                else
                {
                    System.Console.WriteLine("Ingresar una opción válida(a, b o c)");

                }
            }
            while (validacionIngresoPago);
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Ocurrió una excepción" + e.Message);
        }
    }
    //¿Como implementarlo?
    static bool ValidarEntradaCaracteres(string variable)
    {
        string[] caracteres = new string[] { "!", "·", "$", "%", "&", "/", "()", "=", "¿", "¡", "?", "_", ":", ";", ",", "|", "@", "#", "€", "*", @"""" };
        for (int i = 0; i < caracteres.Length; i++)
        {
            if (variable.Contains(caracteres[i]))
            {
                System.Console.WriteLine("No ingresar caracteres especiales");

            }
        }
        return true;
    }
}