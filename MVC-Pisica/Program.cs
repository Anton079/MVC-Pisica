using MVC_Pisica;

internal class Program
{
    public static void Main(string[] args)
    {
        PisicaService service = new PisicaService();

        service.LoadData();

        List<Pisica> pisicas = service.FilterCatsByAge();
        foreach(Pisica x in pisicas)
        {
            Console.WriteLine(x.PisicaInfo());
        }
    }
}