using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Employee
    {
        private string _name;
        private int _age;
        private string _email;
        private string _phone;
        private string _address;

        public void SetName(string name)
        {
            if (name.Length < 2)
            {
                Console.WriteLine("please enter a valid name");
            }
            else _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetPhone(string phone)
        {
            _phone = phone;
        }
        public string GetPhone()
        {
            return _phone;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
        public string GetAdress()
        {
            return _address;
        }
    }
}
