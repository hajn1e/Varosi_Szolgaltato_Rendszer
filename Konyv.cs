namespace Varosi_Szolgaltato_Rendszer;

internal class Konyv
{
    public string Cim { get; }
    public string Szerzo { get; }
    public int Oldalszam { get; }
    public int Ertek { get;  }
    public int Peldanyszam { get; set; }
    
    public Konyv(string cim, string szerzo, int oldalszam, int ertek, int peldanyszam)
    {
        Cim = cim;
        Szerzo = szerzo;
        Oldalszam = oldalszam;
        Ertek = ertek;
        Peldanyszam = peldanyszam;
    }
    
}