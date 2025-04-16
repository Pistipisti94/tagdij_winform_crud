using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tagdij_winform_crud
{
    internal class Ugyfel
    {
        public int azon;
        public string nev;
        public DateTime szuldatum;
        public int irszam;
        public string orszag;

        public Ugyfel(int azon, string nev, DateTime szuldatum, int irszam, string orszag)
        {
            this.azon = azon;
            this.nev = nev;
            this.szuldatum = szuldatum;
            this.irszam = irszam;
            this.orszag = orszag;
        }
        public override string ToString()
        {
            return $"{azon};{nev};{szuldatum.ToString("yyyy-MM-dd")};{irszam};{orszag}";
        }
    }
}
