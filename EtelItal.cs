namespace Varosi_Szolgaltato_Rendszer;

internal class EtelItal
{
    public string Nev { get; }
    public int Ar { get; }
    public string Tipus { get; } 
    public int Koffein { get; }
    public int Kaloria { get; }

    public EtelItal(string nev, int ar, string tipus, int koffein, int kaloria)
    {
        Nev = nev;
        Ar = ar;
        Tipus = tipus;
        Koffein = koffein;
        Kaloria = kaloria;
    }
}