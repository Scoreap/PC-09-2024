namespace Semana19;

class Restaurante
{
    public string OrdenCliente { get; set; }
    public Restaurante(){}
    public Restaurante(string ordenCliente)
    {
        this.OrdenCliente = ordenCliente;
    }
}