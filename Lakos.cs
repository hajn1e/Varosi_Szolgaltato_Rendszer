namespace Varosi_Szolgaltato_Rendszer;

internal class Lakos
{
    public string Nev;
    public int Eletkor;
    public string Lakcim;
    public int Penzosszeg;

    public Lakos(string nev, int eletkor, string lakcim, int penzosszeg)
    {
        Nev = nev;
        Eletkor = eletkor;
        Lakcim = lakcim;
        Penzosszeg = penzosszeg;
    }

    public void BelepSzolgaltatasba(string szolgaltatas)
    {
        Console.WriteLine($"{Nev} sikeresen belépett {szolgaltatas} szolgáltatásba");
    }

    public void Fizet(int osszeg)
    {
        if (osszeg <= Penzosszeg)
        {
            Penzosszeg -= osszeg;
            Console.WriteLine($"{Nev} fizet {osszeg} osszeg");
        }
        else
        {
            Console.WriteLine("Fizetés nem sikerült");
        }
    }

    public void HasznalKozlekedest(KozlekedesiJarmu jarmu)
    {
        jarmu.Felszallas(this);
    }

   
}