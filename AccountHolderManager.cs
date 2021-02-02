using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AccountManagement
{
    public class AccountHolderManager
    {
        //public List<AccountHolder> AccountHolders = new List<AccountHolder>();
        public List<AccountHolder> AccountHolders;
        public AccountHolderManager()
        {
            AccountHolders = new List<AccountHolder>();
            try
            {
                var lines = File.ReadAllLines("accountholders.txt");
                foreach (var line in lines)
                {
                    var accountHolder = AccountHolder.Parse(line);
                    AccountHolders.Add(accountHolder);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Read(AccountHolder accountHolder)
        {
            Console.WriteLine($"{accountHolder.Id} {accountHolder.FirstName} {accountHolder.LastName} {accountHolder.MiddleName} {accountHolder.DateOfBirth} {accountHolder.Email} {accountHolder.Address} {accountHolder.PhoneNumber} {accountHolder.Password}");
        }

        public void List()
        {
            foreach (AccountHolder accountHolder in AccountHolders)
            {
                Read(accountHolder);
            }
        }

        public void CreateAccountHolder(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, string email, string phoneNumber, string address, string password)
        {
            AccountHolder accountHolder = new AccountHolder(id, firstName, lastName, middleName, dateOfBirth, email, phoneNumber, address, password);
            AccountHolders.Add(accountHolder);
            TextWriter writer = new StreamWriter("accountholders.txt", true);
            writer.WriteLine(accountHolder.ToString());
            writer.Close();
        }

        private void RefreshFile()
        {
            TextWriter writer = new StreamWriter("accountholders.txt");
            foreach (AccountHolder accountHolder in AccountHolders)
            {
                writer.WriteLine(accountHolder);
            }
            writer.Flush();
            writer.Close();

        }
    }
}
