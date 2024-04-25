using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_assignment
{
    [Flags]
    enum Role
    {
        Admin = 1,
        Accountant = 2,
        Stock = 4,
        Reception = 8
    }
    internal struct Employee
    {
        string name;
        decimal salary;
        Role role;

        public Employee(string _name , decimal _salary , Role _role)
        {
            name = _name;
            salary = _salary;
            role = _role;
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine($"\nname : {name}");
            Console.WriteLine($"salary : {salary}");
            Console.WriteLine($"role : {role}");
        }
        public void AssignRole(Role _role)
        {
            if(HasRole(_role))
            {
                throw new Exception("The employee already has this role ! "); 
            }
            else
            {
                 role = role | _role; 
            }
        }
        private bool HasRole(Role _role)
        {
            if((role & _role) == _role)
            {
                return true;
            }
            return false;
        }
    }
}
