using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalKezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> jatekosok= new List<Jatekos>();
            foreach (string jatekos in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                jatekosok.Add(new Jatekos(jatekos));
            }

            Console.WriteLine("3. feladat: {0}", jatekosok.Count);

            Console.WriteLine("4. feladat: ");
            foreach (Jatekos jatekos in jatekosok)
            {
                if (jatekos.Utolso.Year == 1999 && jatekos.Utolso.Month == 10)
                {
                    Console.WriteLine("\t{0},{1:F1}cm",jatekos.Nev , jatekos.MagassagCm);
                }
            }
            Console.WriteLine("5. feladat: ");
            int ev;
            do
            {
                Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
                ev = Convert.ToInt32(Console.ReadLine());
                if (ev < 1990 || ev > 1999)
                {
                    Console.Write("Hibás adat!");
                }
            } while (ev < 1990 || ev > 1999);

            // 6 feladat innen kezdődik

            int jatekosokSzama = 0;
            int sulyokOsszege = 0;
            foreach (Jatekos jatekos in jatekosok)
            {
                if (jatekos.Elso.Year <= 0 || jatekos.Utolso.Year >=0)
                {
                    jatekosokSzama++;
                    sulyokOsszege += jatekos.Suly;
                }
            }
            double atlag = (double)sulyokOsszege / jatekosokSzama;
            Console.WriteLine("6. feladat: {0:F2}font", atlag);


            Console.WriteLine("A program vége!");
            Console.ReadKey();
        }
    }
}
