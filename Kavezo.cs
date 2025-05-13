namespace Varosi_Szolgaltato_Rendszer;

internal class Kavezo
{
    public List<EtelItal> Menu { get; } = new List<EtelItal>();
    public List<Lakos> Vendeglista { get; } = new List<Lakos>();

    public void Rendel(Lakos lakos, string termekNev)
    {
       var termek = Menu.Find(e=> e.Nev == termekNev);
       if (termek == null)
       {
           Console.WriteLine("Nincs ilyen termék a menüben.");
           return;
       }if(!Vendeglista.Contains(lakos))
       {
           Vendeglista.Add(lakos);
           Console.WriteLine($"{lakos.Nev} rendelt {termekNev}.");
       }
    }
    
    public void Fizet(Lakos lakos, int osszeg)
    {
        if (lakos.Penzosszeg >= osszeg)
        {
            lakos.Penzosszeg -= osszeg;
            Console.WriteLine($"{lakos.Nev} kifizette a rendelését.");
        }
        else
        {
            Console.WriteLine($"{lakos.Nev} nem tudta kifizetni a rendelését.");
        }
    }
    
    public void Fogyaszt(string termek, Lakos lakos)
    {
        var etelItal = Menu.Find(e => e.Nev == termek);
        if (etelItal != null)
            Console.WriteLine($"{lakos.ToString()} elfogyasztotta: {termek}");
        else
            Console.WriteLine($"{termek} nincs a menüben.");
    }
}