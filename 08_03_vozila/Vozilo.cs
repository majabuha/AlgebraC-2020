using System;

namespace _08_03_vozila
{
<<<<<<< HEAD
    internal class Vozilo
=======
    public class Vozilo
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
    {
        public Vozilo(string Naziv, string Boja, int KS)
        {
            this.Naziv = Naziv;
            this.Boja = Boja;
            this.KS = KS;
        }

        public string Naziv { get; }
        public string Boja { get; }
        public int KS { get; }

        public override string ToString()
        {
            return this.Naziv + " Boja:" + this.Boja + " snaga:" + KS2KW();

        }

        private string KS2KW()
        {
            return (KS * 0.736).ToString();
        }
    }
}