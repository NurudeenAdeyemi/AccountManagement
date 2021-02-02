using System;

namespace AccountManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccountHolderManager accountHolderManager = new AccountHolderManager();
            
            accountHolderManager.CreateAccountHolder(001, "Fadeyi", "Oloro", "NairaMarley", new DateTime(2020,02,12), "oloro@gmail.com", "08080080088", "CodeLeranersHub", "password");
            accountHolderManager.CreateAccountHolder(002, "Shola", "Oloro", "NairaMarley", new DateTime(2020, 02, 12), "oloro@gmail.com", "08080080088", "CodeLeranersHub", "password");
            accountHolderManager.List();
            Console.ReadKey();
        }
    }
}
