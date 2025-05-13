namespace Varosi_Szolgaltato_Rendszer;

internal class Kavezo
{
    public List<EtelItal> Menu { get; } = new List<EtelItal>();
    public List<Lakos> Vendeglista { get; } = new List<Lakos>();

    public void Rendel(Lakos lakos, string termekNev)
    {
        var termek = Menu.FirstOrDefault(e => e.Nev == termekNev);
        if (termek != null)
        {
            Vendeglista.Add(lakos);
            Console.WriteLine($"{lakos.Nev} rendelt: {termek.Nev}");
        }
        else
        {
            Console.WriteLine($"{lakos.Nev} nem tudott rendelni.");
        }
    }

    public void Fogyaszt(Lakos lakos)
    {
        Console.WriteLine($"{lakos.Nev} elfogyasztotta rendelését.");
    }
}