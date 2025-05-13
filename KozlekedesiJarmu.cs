namespace Varosi_Szolgaltato_Rendszer;

internal class KozlekedesiJarmu
{
    public string JarmuNeve { get; set; }
    public List<string> Utvonal { get; set; }
    public int Ferohely { get; set; }
    public int Jegyar { get; set; }
    public List<Lakos> Utasok { get; set; } = new List<Lakos>();

    private int aktualisMegalloIndex = 0;

    public KozlekedesiJarmu(string jarmuNeve, int ferohely, int jegyar)
    {
        JarmuNeve = jarmuNeve;
        Utvonal = new List<string>();
        Ferohely = ferohely;
        Jegyar = jegyar;
        Utasok = new List<Lakos>();
    }

    public void Felszallas(Lakos lakos)
    {
        if (Utasok.Count < Ferohely && lakos.Penzosszeg>= Jegyar)
        {
            Utasok.Add(lakos);
            lakos.Fizet(Jegyar);
            Console.WriteLine($"{lakos.Nev} sikeresen felszállt {JarmuNeve} járműre.");
        }
        else
        {
            Console.WriteLine("Az utasnak nem sikerült felszállnia járműre");
        }
    }

    public void Lepes()
    {
        if (Utvonal.Count==0)
        {
            Console.WriteLine("A jármű nem tud haladni, nincs megadva úvonal");
            return;
        }
        aktualisMegalloIndex = (aktualisMegalloIndex + 1) % Utvonal.Count;
        string jelenlegiMegallo = Utvonal[aktualisMegalloIndex];
        Console.WriteLine($"{JarmuNeve} megérkezett ide: {jelenlegiMegallo}");
    }

    public void HozzaadMegallo(string megallo)
    {
        Utvonal.Add(megallo);
        Console.WriteLine($"{megallo} sikeresen hozzáadva az útvonalhoz");
    }
}