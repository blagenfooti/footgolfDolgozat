using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace footgolf
{
    class Program
    {
        static List<golf> versenyzok;
        static void Main(string[] args)
        {
            Beolvas();
            F03();
            F04();
            //F05();
            Console.ReadKey();
        }

        private static void F05()
        {
            List<int> pontok;
            for (int j = 0; j < versenyzok.Count; j++)
            {              
                    //pontok.Add(versenyzok[j].pont1);  
            }
        }

        private static void F04()
        {
            double no = 0;
            foreach (var e in versenyzok)
            {
                if (!e.Kategoria)
                {
                    no++;
                }
            }
            double atlag = Math.Round((no / versenyzok.Count)*100 ,2);
            Console.WriteLine($"f04: {atlag}");
        }

        private static void F03()
        {
            Console.WriteLine($"f03: {versenyzok.Count}");
        }

        private static void Beolvas()
        {
            versenyzok = new List<golf>();
            var sr = new StreamReader("fob2016.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                versenyzok.Add(new golf(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
