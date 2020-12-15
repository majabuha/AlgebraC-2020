using System;
using System.Collections.Generic;

namespace Maja_domaci_rad_16122020
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Domaci rad 16.12.2020. - Cokoladna ekstaza :)");

            Kolac K1 = new Kolac("Cokoladna ekstaza");
            
            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Secer", 100);
            K1.DodajSastojak("Cokolada", 300);
            K1.DodajSastojak("Jaje", 50); //g

            Rerna.Ispeci(ref K1);

            Kolac K2 = new Kolac("Vanilijska ekstaza :)");
            
            K2.DodajSastojak("Margarin", 200);
            K2.DodajSastojak("Secer", 100);
            K2.DodajSastojak("Vanilija", 300);
            K2.DodajSastojak("Jaje", 50); //g

            Rerna.Ispeci(ref K2);

            for (int i = 0; i < K1.listaSastojaka.Count; i++)
            {
                string Sastojak = K1.listaSastojaka[i];
                int Kolicina = K1.listaKolicina[i];
        
                Console.WriteLine("Dodaj sastojak {0}, {1} grama.", Sastojak, Kolicina);
            }
            double UkupnaKolicina = 0;

            foreach (var item in K1.listaKolicina)
            {
                UkupnaKolicina += item;

            }
            Console.WriteLine("Ukupna tezina je: {0} kg.", Math.Round(((double)UkupnaKolicina / 1000), 2));

            if (K1.jePecen == false)
            {
                K1.DodajSastojak("Limun", 100);
                Console.WriteLine("Limun je dodan.");
            }
            else
            {
                Console.WriteLine("Ne mogu dodati više sastojaka, kolac je vec pecen!");
            }

            Console.WriteLine("Broj ispecenih kolaca je: {0}.", Rerna.BrojIspecenihKolaca);

            Console.ReadKey();

        }      
    }
}
