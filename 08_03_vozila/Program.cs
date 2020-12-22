using System;

namespace _08_03_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo v1 = new Vozilo(
                Naziv: "vozzz",
                Boja: "Zuta",
                KS: 120);
            Console.WriteLine(v1);

<<<<<<< HEAD
            Automobil a1 = new Automobil(Naziv: "Fiat",
=======
            Automobil a1 = new Automobil(
                Naziv: "Fiat",
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
                Boja: "Crveni",
                KS: 200,
                Ccm: 2200);
            Console.WriteLine(a1);

<<<<<<< HEAD
            Brod b1 = new Brod(Naziv: "Marija",
    Boja: "Bijela",
    KS: 35000,
    Istisnina: 5000);
            Console.WriteLine(b1);
=======
            Brod b1 = new Brod(
                Naziv: "Marija",
                 Boja: "Bijela",
                 KS: 35000,
                Istisnina: 5000);
            Console.WriteLine(b1);

            Automobil a2 = new Automobil(
                KS: 100,
                Ccm: 800);
            Console.WriteLine(a2);
            Console.ReadKey();
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
        }
    }
}
