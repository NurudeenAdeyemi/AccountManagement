using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public class AccountHolder
    {
        public int Id;

        public string FirstName;

        public string LastName;

        public string MiddleName;

        public DateTime DateOfBirth;

        public string Email;

        public string PhoneNumber;

        public string Address;

        public string Password;

        public AccountHolder(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, string email, string phoneNumber, string address, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Password = password;

        }

        internal static AccountHolder Parse(string line)
        {
            var props = line.Split('\t');
            int id = int.Parse(props[0]);
            DateTime dateOfBirth = DateTime.Parse(props[4]);
            return new AccountHolder(id, props[1], props[1], props[3], dateOfBirth, props[5], props[6], props[7], props[8]);
        }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{LastName}\t{MiddleName}\t{DateOfBirth}\t{Email}\t{PhoneNumber}\t{Address}\t{Password}";
        }
    }
}
