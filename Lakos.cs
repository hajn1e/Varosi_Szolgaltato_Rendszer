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

    public bool Fizet(int osszeg)
    {
        if (osszeg <= Penzosszeg)
        {
            Penzosszeg -= osszeg;
            return true;
        }else
        {
            
            return false;
        }
    }

    public void HasznalKozlekedest(KozlekedesiJarmu jarmu)
    {
        jarmu.Felszallas(this);
    }

   public override string ToString()
   {
        return $"{Nev}, {Eletkor} éves, lakcím: {Lakcim}, pénzösszeg: {Penzosszeg} Ft";
    }
}