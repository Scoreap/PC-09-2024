namespace Semana19;

class PedidoCliente
{
    public DateTime FechaPedido { get; set; }
    public string NombreCliente { get; set; }
    public string FormaDePago { get; set; }
    public List<Restaurante> DescripcionPedido { get; set; }
    public string NotaPedido { get; set; }
    public decimal PrecioPedido { get; set; }
    public List<string[]> AgregarPedido = new List<string[]>();

    public PedidoCliente() { }
    public PedidoCliente(DateTime fechaPedido, string nombreCliente, List<Restaurante> descripcionPedido, string notaPedido, decimal precioPedido, string formaDePago)
    {
        this.FechaPedido = fechaPedido;
        this.NombreCliente = nombreCliente;
        this.DescripcionPedido = descripcionPedido;
        this.NotaPedido = notaPedido;
        this.PrecioPedido = precioPedido;
        this.FormaDePago = formaDePago;

    }
    public void CrearPedido(DateTime fechaPedido, string nombreCliente, string notaPedido,string formaDePago, decimal precioPedido, string descripcionPedido)
    {
        AgregarPedido.Add(new string[] { fechaPedido.ToString(), nombreCliente,notaPedido,formaDePago, precioPedido.ToString(), descripcionPedido });
    }
    public void RegistroPedidos()
    {
        foreach (var pedido in AgregarPedido)
        {
            System.Console.WriteLine("Fecha" +"                   "+ "Cliente\t" + "Nota                   " + "Forma de Pago\t" + "Precio\t" + "Orden\t");
            System.Console.WriteLine(pedido[0] + "\t" + pedido[1] + "\t" + pedido[2] + "               " + pedido[3] + "\t" + pedido[4] + "\t"+ pedido[5]+ "\t");

        }
    }


}