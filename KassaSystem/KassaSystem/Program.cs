using System;

namespace KassaSystem;
class Program
{
    static List<Account> accounts = new List<Account>();
    static List<AccountHistory> accountHistory = new List<AccountHistory>();

    static void Main(string[] args)
    {
        ElectronKassa ElectronCashierSystem = null;


    while (true)
        {
            Console.WriteLine("E-kassa sistemine xos gelmisiniz !");
            Console.WriteLine("1. E-Kassa yarat.");
            Console.WriteLine("2. E-Kassaya bağlı hesab yarat");
            Console.WriteLine("3. E-kassaya bağlı bütün hesabları göstər");
            Console.WriteLine("4. Hesab nömrəsinə görə hesabı görüntüləmək");
            Console.WriteLine("5. Çıxış.");

            int operationNumber = int.Parse(Console.ReadLine());

            if (operationNumber == 1)
            {
                ElectronCashierSystem = new ElectronKassa();
                List<Account> accounts = new List<Account>();
               ElectronCashierSystem.accounts = accounts;

            }
            else if (operationNumber == 2)
            {
                Console.WriteLine("Hesabın təyinatı:");
                string HesabTeyinati = Console.ReadLine();
                Console.WriteLine("Pul vahidi:");
                string pulVahidi = (Console.ReadLine());
                Console.WriteLine("Pul elave:");
                int PulElave = int.Parse(Console.ReadLine());


                Random random = new Random();
                int HesabNomresi = random.Next(10000000, 99999999);
                Account account1 = new Account();
                account1.Aciqlama = HesabTeyinati;
                account1.HesabNomre = HesabNomresi;
                account1.HesabBalans = PulElave;
                account1.PulVahidi = pulVahidi;
                account1.CariVeziyyet = true;
                ElectronCashierSystem.accounts.Add(account1);
                accountHistory.Add(Management.TarixceyeElaveEt(account1, "Hesabin yaradilmasi"));
                Console.WriteLine($"Təbriklər! '{HesabTeyinati}' təyinatlı hesabınız uğurla yaradıldı. Hesab nömrəniz: {HesabNomresi}");
            }
            bool hesabVar = true;
            foreach (Account account in ElectronCashierSystem.accounts)
            {
                if (account.HesabNomre == 0)
                {
                    hesabVar = false;
                    break;
                }
            }

            if (hesabVar)
            {
                Console.WriteLine("The customer has an account.");
            }
            else
            {
                Console.WriteLine("The customer does not have an account.");
            }


            if (operationNumber == 3)
            {
                if (ElectronCashierSystem != null)
                {
                    Console.WriteLine("AccountNo, Balance,Currency, Açıqlama, Cari V");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    foreach (Account account in ElectronCashierSystem.accounts)
                    {
                        Console.WriteLine($"{account.HesabNomre} " +
                            $"{account.HesabBalans} " +
                            $"{account.PulVahidi}      " +
                            $"{account.Aciqlama}    " +
                            $"{account.CariVeziyyet}");
                    }
                }
                else
                {
                    Console.WriteLine("E-Kassa yaradilmamisdir.");
                }
            }


            if (operationNumber == 4)
            {

                while (true)

                {

                    Console.WriteLine("Emeliyyat nomresini daxil edin:");
                    Console.WriteLine("1. Hesab nömrəsinə görə hesabı görüntüləmək:");
                    Console.WriteLine("2. Hesaba pul yatır:");
                    Console.WriteLine("3. Hesabdan pul çek: ");
                    Console.WriteLine("4. Hesab hərəkətini göstər:");
                    Console.WriteLine("5. Hesabı Active/Deactive et: ");
                    Console.WriteLine("6. Əsas menyu geri dön: ");
                    Console.Write("Enter the transaction number: ");
                    int Operationİndex = int.Parse(Console.ReadLine());


                    Account selectedAccount = null;
                    if (Operationİndex != 6 && Operationİndex != 7)
                    {
                        Console.WriteLine("Hesab nomresini daxil edin:");
                        int AccountNumber = int.Parse(Console.ReadLine());

                        foreach (Account account in ElectronCashierSystem.accounts)
                        {
                            if (account.HesabNomre == AccountNumber)
                                selectedAccount = account;
                        }
                    }

                    switch (Operationİndex)
                    {
                        case 1:

                            Management.HesabiGoster(selectedAccount);

                            break;

                        case 2:

                            Console.WriteLine("Yatırılacaq məbləği daxil edin:");
                            int mebleg = int.Parse(Console.ReadLine());
                            Management.PulYatir(selectedAccount, mebleg);
                            accountHistory.Add(Management.TarixceyeElaveEt(selectedAccount, "Hesaba pul elave olunmasi"));
                            break;

                        case 3:

                            Console.WriteLine("Çəkiləcək məbləği daxil edin:");
                            int mebleg1 = int.Parse(Console.ReadLine());
                            if (mebleg1 > selectedAccount.HesabBalans)
                            {
                                Console.WriteLine("Mebleg balansdan coxdur");
                            }
                            else
                            {
                                Management.PulCek(selectedAccount, mebleg1);
                                accountHistory.Add(Management.TarixceyeElaveEt(selectedAccount, "Hesabdan pul cekilmesi"));
                            }
                            break;

                        case 4:

                            Management.HesabHareketiGoster(accountHistory, selectedAccount);
                            break;

                        case 5:
                            Console.WriteLine("Hesabı Active/Deactive et: (A/D)");
                            string aktiv = Console.ReadLine();
                            Management.HesabiAktivDeaktivEt(selectedAccount, aktiv);
                            accountHistory.Add(Management.TarixceyeElaveEt(selectedAccount, "HHesabı Active/Deactive edilmesi"));
                            break;

                        case 6:
                            continue;

                        

                    }
                }
            }
        }
    }
}










