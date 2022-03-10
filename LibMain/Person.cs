using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMain
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string address;
        private DateTime dob;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public string getFirtName()
        {
            return this.FirstName;
        }
        public string getLastName()
        {
            return this.LastName;
        }

        public int getAge()
        {
            return this.Age;
        }

        public string getAddress()
        {
            return this.Address;
        }

        public DateTime getDob()
        {
            return this.Dob;
        }

        public void setFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.LastName = lastName;
        }
        public void setAge(int age)
        {
            this.Age = age;
        }
        public void setAddress(string address)
        {
            this.Address = address;
        }
        public void setDob(DateTime dob)
        {
            this.Dob = dob;
        }
        
        public string toString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age} {this.Address} {this.Dob}";
        }
    }
}
