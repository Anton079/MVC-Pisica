using MVC_Pisica;

internal class Program
{
    public static void Main(string[] args)
    {
        PisicaService service = new PisicaService();

        service.LoadData();

        Pisica pisicaNoua = new Pisica();
        pisicaNoua.varstaAni = 6;
        pisicaNoua.inaltimeCm = 28;
        pisicaNoua.rasaPisica = "Ragdoll";

    }
}