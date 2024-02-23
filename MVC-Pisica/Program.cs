using MVC_Pisica;

internal class Program
{
    public static void Main(string[] args)
    {
        PisicaService service = new PisicaService();

        service.LoadData();
        service.AfisarePisica();
    }
}