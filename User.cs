using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class User
    {
      public User(string name)
        {
            this.Name = name;
        }
        private string _name;
        private string _password;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value.Length > 5 && value.Length < 25) ;
                this._name = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if(value.Length > 7 && value.Length < 26) ;
                this._password = value;
            }
        }
        static bool CheckString(string str)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    hasUpper = true;
                else if (char.IsLower(str[i]))
                   hasLower = true;
                else if(char.IsDigit(str[i]))
                    hasDigit = true;
                if(hasDigit && hasLower && hasUpper)
                    return true;
            }
            return false;
        }
            
    }
}
