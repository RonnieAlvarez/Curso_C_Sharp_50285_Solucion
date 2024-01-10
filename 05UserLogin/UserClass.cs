using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05UserLogin
{
    internal class UserClass
    {
        private string _userName;
        private string _lastName;
        private string _email;
        private string _dni;
        private string _address;
        private int _age;
        //Class Constructors
        public UserClass()
        {
            this._userName = string.Empty;
            this._lastName = string.Empty;
            this._email = string.Empty;
            this._dni = string.Empty;
            this._address = string.Empty;
            this._age = 0;
        }
        public UserClass(string userName, string lastName, string email, string dni, string address, int age)
        {
            this._userName = userName;
            this._lastName = lastName;
            this._email = email;
            this._dni = dni;
            this._address = address;
            this._age = age;
        }
        //Getters & Setters
        public string Username
        { get { return this._userName; } set { this._userName = value; } }
        public string LastName
        { get { return this._lastName; } set { this._lastName = value; } }
        public string Email
        { get { return this._email; } set { this._email = value; } }
        public string Dni
        { get { return this._dni; } set { this._dni = value; } }
        public string Address
        { get { return this._address; } set { this._address = value; } }
        public int Age
        { get { return this._age; } set { this._age = value; } }
        //Methods
        public bool IsAdult()
            { return this._age > 18; }
        public string Name()
            { return this._userName + " " + this._lastName; }

        public bool IsGmailProvider()
            { return this._email.Contains("@gmail.com"); }

    }
}
