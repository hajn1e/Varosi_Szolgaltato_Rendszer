namespace Varosi_Szolgaltato_Rendszer;

internal class Varos
{
    //Tartalmazza az összes szolgáltatás objektumát, valamint lakókat.
    private List<object> szolgaltatok= new();
    private List<Lakos> lakosok = new();
    
    public void HozzaadLakos(Lakos lakos)
    {
        if (lakos != null)
        {
            lakosok.Add(lakos);
            Console.WriteLine($"{lakos.Nev} lakos hozzáadva a városhoz.");
        }
    }

    public void Napfutasa()
    {
        Console.WriteLine("Eltelt egy nap a városban.");
    }
    
    public void SzolgaltatasInditasa(object szolgaltatas)
    {
        if (szolgaltatas != null)
        {
            szolgaltatok.Add(szolgaltatas);
            Console.WriteLine($"{szolgaltatas.GetType().Name} szolgáltatás elindult.");
        }
    }
    
    public void VarosStatusza()
    {
        Console.WriteLine($"A városban {lakosok.Count} lakos és {szolgaltatok.Count} szolgáltatás található.");
        foreach (var lakos in lakosok)
        {
            Console.WriteLine(lakos.ToString());
        }
    }
}