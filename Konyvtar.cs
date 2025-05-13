namespace Varosi_Szolgaltato_Rendszer;

internal class Konyvtar
{
   public List<Konyv> konyvlista = new List<Konyv>();
   public int MaximalisKpacitas { get; set; }

   public void HozzaadKony(Konyv konyv)
   {
       
       if (konyvlista.Count > MaximalisKpacitas)
       {
           Console.WriteLine("Megtelt a knyvtár nem lehet több önyvet hozzáadni");
       }
       else
       {
           konyvlista.Add(konyv);
           Console.WriteLine($"{konyv.Cim} sikeresen hozzáadva a könyvtárhoz");
       }
   }
   
   public void Kolcsonoz(Konyv konyv, Lakos lakos)
   {
       if (konyvlista.Contains(konyv) && konyv.Peldanyszam > 0)
       {
           konyv.Peldanyszam--;
           Console.WriteLine($"{lakos.Nev} sikeresen kikölcsönözte {konyv.Cim}");
       }
       else
       {
           Console.WriteLine("nem sikerült");
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