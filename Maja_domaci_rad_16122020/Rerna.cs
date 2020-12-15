using System;
using System.Collections.Generic;

namespace Maja_domaci_rad_16122020
{
    internal class Rerna
    {
        public static int BrojIspecenihKolaca;

        internal static void Ispeci(ref Kolac K)
        {
            K.jePecen = true;
            BrojIspecenihKolaca++;
        }
    }
}