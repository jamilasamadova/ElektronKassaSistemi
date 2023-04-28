using System;
using KassaSystem;

namespace KassaSystem
{
	
	public class ElectronKassa
    {
        public List<Account> accounts = new List<Account>();
        public ElectronKassa()
        {

            Console.WriteLine("Istifadəçi adını daxil edin:");
            string Username = Console.ReadLine();
            Console.WriteLine("Sifreni daxil edin:");
            int Password = int.Parse (Console.ReadLine());

            Console.WriteLine($"Təbriklər! '{Username}' adlı E-Kassa uğurla yaradıldı.");
        }
    }
}




