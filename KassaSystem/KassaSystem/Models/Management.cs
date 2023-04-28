using System;
namespace KassaSystem
{
	public class Management
	{
		
		
		public static void HesabiGoster(Account account)
		{
            Console.WriteLine("HesabNo, Balans, Pul vahidi, Açıqlama, Cari V");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"{account.HesabNomre} " +
                            $"{account.HesabBalans} " +
                            $"{account.PulVahidi}      " +
                            $"{account.Aciqlama}    " +
                            $"{account.CariVeziyyet}");

        }

        public static Account PulYatir(Account account, int artirilacaqMebleg)
		{
			account.HesabBalans += artirilacaqMebleg;
			return account;
		}
        public static Account PulCek(Account account, int azaldilacaqMebleg)
		{
            account.HesabBalans -= azaldilacaqMebleg;
            return account;

        }
        public static void HesabHareketiGoster(List<AccountHistory> accountHistory, Account account)
		{
            Console.WriteLine("HesabNo, Balans, Pul vahidi, Açıqlama, Cari V, Emeliyyat");
            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (AccountHistory history in accountHistory) {
                if (history.HesabNomre == account.HesabNomre)
                {
                    Console.WriteLine($"{history.HesabNomre} " +
                          $"{history.HesabBalans} " +
                          $"{history.PulVahidi}      " +
                          $"{history.Aciqlama}    " +
                          $"{history.CariVeziyyet}"+
                          $"{history.Emeliyyat}");
                }
            }
		}
        public static Account HesabiAktivDeaktivEt(Account account, string aktiv)
		{
            if (aktiv == "A")
            {
                account.CariVeziyyet = true;
            }
            if (aktiv == "D")
            {
                account.CariVeziyyet = false;
            }
			return account;

		}

        public static AccountHistory TarixceyeElaveEt(Account account, string operation)
        {
            AccountHistory accountHistory = new AccountHistory(account.HesabNomre,
                account.HesabBalans, account.PulVahidi, account.Aciqlama, account.CariVeziyyet, operation);
            return accountHistory;
      
        }

    }



}

