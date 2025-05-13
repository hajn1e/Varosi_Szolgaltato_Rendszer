// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using Varosi_Szolgaltato_Rendszer;

namespace Városi_Szolgáltató_Rendszer;

class Program
{
    static void Main(string[] args)
    {
        Varos varos = new Varos();
        Lakos lakos1 = new Lakos("Kiss Péter", 30, "Fő utca 1", 10000);
        Lakos lakos2 = new Lakos("Nagy Anna", 25, "Kis utca 2", 15000);
        Lakos lakos3 = new Lakos("Szabó László", 40, "Régi utca 3", 20000);
        Lakos lakos4 = new Lakos("Tóth Eszter", 35, "Új utca 4", 25000);
        Lakos lakos5 = new Lakos("Kovács Gábor", 28, "Zöld utca 5", 30000);
        Lakos lakos6 = new Lakos("Horváth Júlia", 22, "Sárga utca 6", 35000);
        Lakos lakos7 = new Lakos("Varga Balázs", 32, "Kék utca 7", 40000);
        Lakos lakos8 = new Lakos("Molnár Zsófia", 27, "Piros utca 8", 45000);
        Lakos lakos9 = new Lakos("Farkas András", 29, "Barna utca 9", 50000);
        Lakos lakos10 = new Lakos("Kiss Anna", 31, "Fekete utca 10", 55000);
        
        varos.HozzaadLakos(lakos1);
        varos.HozzaadLakos(lakos2);
        varos.HozzaadLakos(lakos3);
        varos.HozzaadLakos(lakos4);
        varos.HozzaadLakos(lakos5);
        varos.HozzaadLakos(lakos6);
        varos.HozzaadLakos(lakos7);
        varos.HozzaadLakos(lakos8);
        varos.HozzaadLakos(lakos9);
        varos.HozzaadLakos(lakos10);
        
        Konyvtar konyvtar = new Konyvtar(10);
        Konyv konyv1 = new Konyv("A Gyűrűk Ura", "J.R.R. Tolkien", 5, 3000, 10);
        Konyv konyv2 = new Konyv("Harry Potter", "J.K. Rowling", 3, 4000, 15);
        Konyv konyv3 = new Konyv("A Szél neve", "Patrick Rothfuss", 2, 5000, 20);
        Konyv konyv4 = new Konyv("A Hobbit", "J.R.R. Tolkien", 4, 3500, 12);
        Konyv konyv5 = new Konyv("A Trónok Harca", "George R.R. Martin", 1, 6000, 25);
        konyvtar.HozzaadKonyv(konyv1);
        konyvtar.HozzaadKonyv(konyv2);
        konyvtar.HozzaadKonyv(konyv3);
        konyvtar.HozzaadKonyv(konyv4);
        konyvtar.HozzaadKonyv(konyv5);
        varos.SzolgaltatasInditasa(konyvtar);
        konyvtar.Belepes(lakos1);
        konyvtar.Kolcsonoz(konyv1, lakos1);
        konyvtar.Kolcsonoz(konyv2, lakos2);
        konyvtar.Kolcsonoz(konyv3, lakos3);
        
        KozlekedesiJarmu busz = new KozlekedesiJarmu("Busz", 50, 100);
        busz.HozzaadMegallo("Blaha Lujza tér");
        busz.HozzaadMegallo("Deák Ferenc tér");
        busz.HozzaadMegallo("Kálvin tér");
        busz.HozzaadMegallo("Astoria");
        busz.Felszallas(lakos4);
        busz.Felszallas(lakos5);
        busz.Felszallas(lakos6);
        busz.Felszallas(lakos7);
        busz.Felszallas(lakos8);
        busz.Lepes();
        varos.SzolgaltatasInditasa(busz);
        
        Kavezo kavezo= new Kavezo();
        EtelItal kave1 = new EtelItal("Esspresso", 1000, "ital", 20, 150);
        EtelItal kave2 = new EtelItal("Cappuccino", 1500, "ital", 30, 200);
        kavezo.Menu.Add(kave1);
        kavezo.Menu.Add(kave2);
        varos.SzolgaltatasInditasa(kavezo);
        kavezo.Rendel(lakos9, "Esspresso");
        kavezo.Rendel(lakos10, "Cappuccino");
        kavezo.Fogyaszt(kave1.Nev, lakos9);
        kavezo.Fizet(lakos9, 1000);
        kavezo.Fogyaszt(kave2.Nev, lakos10);
        
        Posta posta = new Posta();
        posta.Kuldes(new Csomag(lakos2, lakos4, 1000, 1000));
        posta.Szallitas();
        posta.Atvetel(new Csomag(lakos2, lakos4, 1000, 1000));
        varos.SzolgaltatasInditasa(posta);
        
        varos.Napfutasa();
        
        varos.VarosStatusza();
    }
    
}