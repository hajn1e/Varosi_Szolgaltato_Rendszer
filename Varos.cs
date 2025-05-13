namespace Varosi_Szolgaltato_Rendszer;

internal class Varos
{
    //Tartalmazza az összes szolgáltatás objektumát, valamint lakókat.
    private List<Szolgaltatas> szolgaltatok;
    private List<Lakos> lakosok = new List<Lakos>();

    public Varos()
    {
        szolgaltatok = new List<Szolgaltato>();
        lakosok = new List<Lakos>();
    }

    public void NapFutasa()
    {
        //A városban lévő szolgáltatások napjának futása
        foreach (var szolgaltato in szolgaltatok)
        {
            szolgaltato.NapFutasa();
        }
    }
    
    public void LakosokHozzaadasa(Lakos lakos)
    {
        //Lakosok hozzáadása a városhoz
        lakosok.Add(lakos);
    }
    
    public void SzolgaltatasInditasa(Szolgaltato szolgaltato)
    {
        //Szolgáltatás indítása
        szolgaltatok.Add(szolgaltato);
    }
    
    public void VarosStatusza()
    {
        //A város állapotának kiírása
        Console.WriteLine("A város állapota:");
        foreach (var szolgaltato in szolgaltatok)
        {
            Console.WriteLine(szolgaltato);
        }
        
        foreach (var lakos in lakosok)
        {
            Console.WriteLine(lakos);
        }
    }
}