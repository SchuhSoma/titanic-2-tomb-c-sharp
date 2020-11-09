using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicTMB_Dolgozat
{
    class Program
    {
        static string[] KategoriaTMB = new string[11];
        static int[] TuleloTMB = new int[11];
        static int[] EltuntekTMB = new int[11];
        static void Main(string[] args)
        {
            Feladat0(); Console.WriteLine("\n-----------------------------------\n");
            Feladat1(); Console.WriteLine("\n-----------------------------------\n");
            Feladat2(); Console.WriteLine("\n-----------------------------------\n");
            Feladat3(); Console.WriteLine("\n-----------------------------------\n");
            Feladat4(); Console.WriteLine("\n-----------------------------------\n");
            Feladat5(); Console.WriteLine("\n-----------------------------------\n");
            Feladat6(); Console.WriteLine("\n-----------------------------------\n");
            Feladat7(); Console.WriteLine("\n-----------------------------------\n");
            Feladat8(); Console.WriteLine("\n-----------------------------------\n");
            Console.ReadKey();

        }

        private static void Feladat8()
        {
            Console.WriteLine("8.Feladat: Keresés");
            Console.Write("\tKérem adjon meg egy kategoriát amire rá szeretne keresni (ne használjon ékezetes betüt): ");
            string KulcsSzo = Console.ReadLine().ToLower().Replace(" ","");
            int Szamlalo = 0;
            while(Szamlalo<TuleloTMB.Length && KulcsSzo!=KategoriaTMB[Szamlalo].ToLower().Replace(" ", ""))
            {
                Szamlalo++;
            }
            if(Szamlalo==KategoriaTMB.Length)
            {
                Console.WriteLine("\tSajnos nincs ilyen kategoria");
            }
            else
            {
                Console.WriteLine("\tVan találat");
                Console.WriteLine("\t{0}  túlélők száma: {1}", KulcsSzo,TuleloTMB[Szamlalo]);
                Console.WriteLine("\t{0}  eltűntek száma: {1}", KulcsSzo, EltuntekTMB[Szamlalo]);
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat: Hány esetben volt 60 fölötti a túlélők száma");
            int db = 0;
            for (int i = 0; i < TuleloTMB.Length; i++)
            {
                if(TuleloTMB[i]>60)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt 60 fő fölötti a túlélök száma: {0}",db);
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Legkevesebb eltünt");
            int MinEltunt = int.MaxValue;
            string MinKategoria = "cica";
            for (int i = 0; i < TuleloTMB.Length; i++)
            {
                if(EltuntekTMB[i]<MinEltunt)
                {
                    MinEltunt = EltuntekTMB[i];
                    MinKategoria = KategoriaTMB[i];
                }
            }
            Console.WriteLine("\tA legkevesebb eltünt ebben a kategoriában volt: {0}", MinKategoria);
            Console.WriteLine("\tA legkevesebb eltünt száma: {0} fő",MinEltunt);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: Legtöbb túlélő");
            int MaxTulelo = int.MinValue;
            string MaxKategoria = "cica";
            for (int i = 0; i < KategoriaTMB.Length; i++)
            {
                if(MaxTulelo<TuleloTMB[i])
                { 
                    MaxTulelo = TuleloTMB[i];
                    MaxKategoria = KategoriaTMB[i];
                }
            }
            Console.WriteLine("\tA legtöbb túlélő ebben a kategoriában volt: {0}",MaxKategoria);
            Console.WriteLine("\tA legtöbb túlélő száma: {0}", MaxTulelo);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: Kategoránként az utasok átlaga");
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < TuleloTMB.Length; i++)
            {
                Osszeg += TuleloTMB[i] + EltuntekTMB[i];
            }
            Atlag = Osszeg / TuleloTMB.Length;
            Console.WriteLine("\tKategoriánként az emberek átlaga: {0:0.00} fő", Atlag);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Utasok száma a Titanicon");
            int OsszesUtas = 0;
            for (int i = 0; i < TuleloTMB.Length; i++)
            {
                OsszesUtas += TuleloTMB[i] + EltuntekTMB[i];
            }
            Console.WriteLine("\tA Titanicon ennyien utaztak (túlélő+eltüntek): {0:000} fő",OsszesUtas);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: Kiíratás");
            for (int i = 0; i < KategoriaTMB.Length; i++)
            {
                Console.WriteLine("\tKategorai: {0,-25} -> túlélők száma: {1,-3} --> eltüntek száma: {2,-3}", KategoriaTMB[i],TuleloTMB[i],EltuntekTMB[i]);
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: Tömb nagysága");
            Console.WriteLine("\tA tömb amit létrehoztunk :{0}", KategoriaTMB.Length);
        }

        private static void Feladat0()
        {
            Console.WriteLine("0.Feladat: Feltöltés");
            KategoriaTMB = new string[] { "gyerekek-masodosztaly","nok - elsoosztaly", "nok-hajon dolgozok", "nok-masodosztaly", "gyerekek-elsoosztaly", "nok-harmadosztaly", "gyerekek-harmadosztaly", "ferfiak-elsoosztaly", "ferfiak-legenyseg", "ferfiak-harmadosztaly", "ferfiak-masodosztaly" };
            TuleloTMB = new int[] { 24, 140, 20, 80, 5, 76, 27, 57, 192, 75, 14 };
            EltuntekTMB = new int[] { 0, 4 , 3, 13, 1, 89, 52, 118, 693, 387, 154 };
        }
    }
}
