namespace _08_03_vozila
{
<<<<<<< HEAD
    internal class Automobil:Vozilo
    {
        private string Naziv;
        private string Boja;
        private int KS;
=======
    // public class Automobil:Vozilo
    public class Automobil : Vozilo
    {
        //private string Naziv;
        //private string Boja;
        //private int KS;
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
        private int ccm;

        public Automobil(string Naziv, string Boja, int KS, int Ccm):base(Naziv,Boja,KS)
        {
            this.Ccm = Ccm;
        }
<<<<<<< HEAD
=======
        public Automobil(int KS, int Ccm) : this("default naziv","Default boja", KS, Ccm)
        {
        }
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
        public override string ToString()
        {
            return base.ToString()+" moja kubikaza je:"+this.Ccm;
        }

        public int Ccm { get => ccm; set => ccm = value; }
    }
}