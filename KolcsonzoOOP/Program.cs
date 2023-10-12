using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Halasi-Czalbert Tibor
            Konyv konyv = new Konyv("1984","George Orwell","kasljdsapojfpsafsa");
            //Console.WriteLine(konyv.MeddigKolcsonozheto());
            //Console.WriteLine(konyv.MegjelenitendoNev());
            Dvd dvd = new Dvd("Vuk",110);
            //Console.WriteLine(dvd.MeddigKolcsonozheto());
            //Console.WriteLine(dvd.MegjelenitendoNev());
            Ujsag ujsag = new Ujsag("Times",1999,31);
            //Console.WriteLine(ujsag.MeddigKolcsonozheto());
            //Console.WriteLine(ujsag.MegjelenitendoNev());
            Dvd dvd2 = new Dvd("A három kismalac", 78);
            Dvd dvd3 = new Dvd("MoonFall", 123);
            Dvd dvd4 = new Dvd("Csipkerózsika", 91);
            Dvd dvd5 = new Dvd("Fel!", 64);

            List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
            katalogus.Add(konyv);
            katalogus.Add(dvd);
            katalogus.Add(ujsag);
            foreach (var item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev());
                Console.WriteLine(item.MeddigKolcsonozheto());
            }

            List<Dvd> dvdk = new List<Dvd>();
            dvdk.Add(dvd);
            dvdk.Add(dvd2);
            dvdk.Add(dvd3);
            dvdk.Add(dvd4);
            dvdk.Add(dvd5);
            dvdk.Sort();
            foreach (var item in dvdk) 
            {
                Console.WriteLine(item.MegjelenitendoNev());
                Console.WriteLine(item.MeddigKolcsonozheto());
            }

            Console.ReadKey();
        }
    }
}
