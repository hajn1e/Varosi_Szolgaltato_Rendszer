namespace Varosi_Szolgaltato_Rendszer;

internal class BevasarloKozpont
{
    private List<string> boltok = new();
    private List<Lakos> latogatok = new();

    public void UjBolt(string boltNev)
    {
        if (!string.IsNullOrWhiteSpace(boltNev))
            boltok.Add(boltNev);
    }

    public void Belep(Lakos lakos)
    {
        if (!latogatok.Contains(lakos))
        {
            latogatok.Add(lakos);
            Console.WriteLine($"{lakos.ToString()} belépett a bevásárlóközpontba.");
        }
    }

    public void Kolt(Lakos lakos, int osszeg)
    {
        if (latogatok.Contains(lakos))
        {
            if (lakos.Fizet(osszeg))
                Console.WriteLine($"{lakos.ToString()} vásárolt {osszeg} Ft értékben.");
            else
                Console.WriteLine($"{lakos.ToString()} nem tudott vásárolni, nincs elég pénze.");
        }
        else
        {
            Console.WriteLine($"{lakos.ToString()} nincs a bevásárlóközpontban.");
        }
    }
}