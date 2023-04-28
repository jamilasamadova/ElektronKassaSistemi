using System;
namespace KassaSystem
{
    public class AccountHistory

    {


        public int HesabNomre { get; set; }
        public int HesabBalans { get; set; }
        public string PulVahidi { get; set; }
        public string Aciqlama { get; set; }
        public Boolean CariVeziyyet { get; set; }
        public string Emeliyyat { get; set; }


        public AccountHistory()
        {



        }
        public AccountHistory(int HesabNomre, int HesabBalans, string PulVahidi, string Aciqlama, Boolean CariVeziyyet, string Emeliyyat)
        {

            this.HesabNomre = HesabNomre;
            this.HesabBalans = HesabBalans;
            this.PulVahidi = PulVahidi;
            this.Aciqlama = Aciqlama;
            this.CariVeziyyet = CariVeziyyet;
            this.Emeliyyat = Emeliyyat;
        }
    }
}


