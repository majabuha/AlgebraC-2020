namespace Maja_domaci_rad_16122020
{
    public class Sastojci
    {
        public string Sastojak { get; set; }
        public int Kolicina { get; set; }

        public Sastojci(string ime, int tezina)
        {
            this.Sastojak = ime;
            this.Kolicina = tezina;
        }

    }

    
}