using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Dvd : IKolcsonozheto, IComparable<Dvd>
    {
        private string cim;
        private int hossz;
        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public int CompareTo(Dvd other)
        {
            //pozitív: this
            //negatív: bemenő param
            //0: megegyeznek
            return this.hossz - other.hossz;
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return $"{this.cim} ({this.hossz} perc)";
        }
    }
}
