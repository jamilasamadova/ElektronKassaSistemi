using System;
namespace KassaSystem
{

    //List<Account>accounts=new 
    public class Account

    {
        public int HesabNomre { get; set; }
        public int HesabBalans { get; set; }
        public string PulVahidi { get; set; }
        public string Aciqlama { get; set; }
        public Boolean CariVeziyyet { get; set; }

        public Account()
        {

        }


        public Account(int HesabNomre, int HesabBalans, string PulVahidi, string Aciqlama, Boolean CariVeziyyet)
        {
            this.HesabNomre = HesabNomre;
            this.HesabBalans = HesabBalans;
            this.CariVeziyyet = CariVeziyyet;
            this.PulVahidi = PulVahidi;
            this.Aciqlama = Aciqlama;
        }

    }

}
















