using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_generics___Theo
{
    internal class Employee
    {
        public int _Id { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public int _salary { get; set; }

        public Employee(int ID, string Name, string Gender, int Salary) 
        {
            _Id = ID;
            _name = Name;
            _gender = Gender;
            _salary = Salary;
        }

        
    }
}
