namespace _08_03_vozila
{
<<<<<<< HEAD
    internal class Brod:Vozilo
    {
        private string Naziv;
        private string Boja;
        private int KS;
=======
    public class Brod:Vozilo
    {
        //private string Naziv;
        //private string Boja;
        //private int KS;
>>>>>>> c636db93544f07e247aecbf038b0028e6c082f55
        private int Istisnina;

        public Brod(string Naziv, string Boja, int KS, int Istisnina):base(Naziv, Boja, KS)
        {
            this.Istisnina = Istisnina;
        }
        public override string ToString()
        {
            return "Ja sam brod "+base.ToString() + " moja istisnina je:" + this.Istisnina;
        }
    }
}