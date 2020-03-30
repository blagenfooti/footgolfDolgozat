using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    class golf
    {
        public string Nev { get; set; }
        public bool Kategoria { get; set; }
        public string EgyesuletNev { get; set; }
        public int pont1 { get; set; }
        public int pont2 { get; set; }
        public int pont3 { get; set; }
        public int pont4 { get; set; }
        public int pont5 { get; set; }
        public int pont6 { get; set; }
        public int pont7 { get; set; }
        public int pont8 { get; set; }

        public golf(string s)
        {
            var t = s.Split(';');

            Nev = t[0];
            Kategoria = t[1] == "Felnott ferfi";
            EgyesuletNev =t[2];
            pont1 = int.Parse(t[3]);
            pont2 = int.Parse(t[4]);
            pont3 = int.Parse(t[5]);
            pont4 = int.Parse(t[6]);
            pont5 = int.Parse(t[7]);
            pont6 = int.Parse(t[8]);
            pont7 = int.Parse(t[9]);
            pont8 = int.Parse(t[10]);


        }

    }
}
