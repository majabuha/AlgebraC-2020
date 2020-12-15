using System;
using System.Collections.Generic;

namespace Maja_domaci_rad_16122020
{
    internal class Kolac
    {
       
        public bool jePecen = false;
        public List<string> listaSastojaka = new List<string>();
        public List<int> listaKolicina = new List<int>();
        
        
        public Kolac (string tip)
        {

        }

        internal void DodajSastojak(string Sastojak, int Kolicina)
        {
            listaSastojaka.Add(Sastojak);
            listaKolicina.Add(Kolicina);
        }
      
    }
}