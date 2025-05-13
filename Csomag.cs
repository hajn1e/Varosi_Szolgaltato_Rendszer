namespace Varosi_Szolgaltato_Rendszer;

internal class Csomag
{
    public Lakos Kuldo { get; }
    public Lakos Cimzet { get; }
    public double Suly { get; }
    public int Ar { get; }
    public string Allapot { get; private set; }

    public Csomag(Lakos kuldo, Lakos cimzet, double suly, int ar)
    {
        Kuldo = kuldo;
        Cimzet = cimzet;
        Suly = suly;
        Ar = ar;
        Allapot = "Feladva";
    }

    public void Feladas()
    {
        Allapot = "Feladva";
    }

    public void Szallitas()
    {
        Allapot = "Szállítás alatt";
    }

    public void Kiszallitas()
    {
        Allapot = "Kiszállítva";
    }
}