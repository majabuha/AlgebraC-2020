using System;
using System.Collections.Generic;

namespace Maja_domaci_rad_16122020
{
    internal class Kolac
    {
       
        public bool jePecen = false;

        public List<Sastojci> listaSastojaka = new List<Sastojci>();
        


        public Kolac (string tip)
        {
            
        }

        internal void DodajSastojak(string Sastojak, int Kolicina)
        {
            Sastojci sastojak = new Sastojci(Sastojak, Kolicina);
            listaSastojaka.Add(sastojak);
         }
 
    }

}
