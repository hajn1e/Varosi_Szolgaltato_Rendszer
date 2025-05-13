namespace Varosi_Szolgaltato_Rendszer;

internal class Konyvtar
{
   public List<Konyv> konyvlista = new List<Konyv>();
   private int MaximalisKapacitas;
    
   public Konyvtar(int maximalisKapacitas)
   {
       MaximalisKapacitas = maximalisKapacitas> 0 ? maximalisKapacitas : throw new ArgumentException("A kapacitásnak pozitívnak kell lennie.");
   }
   
   public void HozzaadKonyv(Konyv konyv)
   {
       if (konyvlista.Count < MaximalisKapacitas)
       {
           konyvlista.Add(konyv);
           Console.WriteLine($"{konyv.Cim} sikeresen hozzáadva a könyvtárhoz");
           
       }
       else
       {
           Console.WriteLine("Megtelt a könyvtár nem lehet több könyvet hozzáadni");
       }
   }
   
   public void Kolcsonoz(Konyv konyv, Lakos lakos)
   {
       if (konyvlista.Contains(konyv) && konyv.Peldanyszam > 0)
       {
           konyv.Peldanyszam--;
           Console.WriteLine($"{lakos.Nev} sikeresen kikölcsönözte {konyv.Cim} könyvet");
       }
       else
       {
           Console.WriteLine($"{lakos.Nev} nem sikerült kikölcsönöznie a könyvet");
       }
   }

   public void Belepes(Lakos lakos)
   {
       Console.WriteLine($"{lakos.Nev} belépett a könyvtárba");
   }

   public void Visszahoz(Konyv konyv, Lakos lakos)
   {
       konyv.Peldanyszam++;
       Console.WriteLine($"{lakos.Nev} visszahozta {konyv.Cim} című könyvet");
   }
   
   
}