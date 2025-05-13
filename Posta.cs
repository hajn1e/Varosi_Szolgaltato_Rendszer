namespace Varosi_Szolgaltato_Rendszer;

internal class Posta
{
    public List<Csomag> csomagok = new List<Csomag>();
    
    public void Kuldes(Csomag csomag)
    {
        csomag.Feladas();
        csomagok.Add(csomag);
        Console.WriteLine("Csomag feladva.");
    }

    public void Szallitas()
    {
        foreach (var csomag in csomagok)
            csomag.Szallitas();
    }

    public void Atvetel(Csomag csomag)
    {
        csomag.Kiszallitas();
        Console.WriteLine($"Csomag kézbesítve: {csomag.Cimzet.Nev}");
    }
}