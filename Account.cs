using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public class Account
    {
        public int capacity;
        public string registrationNumber;
        public string type;
        public string name;
        public Account(string name, string type, int capacity, string registrationNumber) //constructor is a method used to instantiate the object , has the same name as the class
        {
            //(this) is a special keyword and a reference to the current instance of the class
            this.name = name;
            this.type = type;
            this.capacity = capacity;
            this.registrationNumber = registrationNumber;
        }
    }
}
