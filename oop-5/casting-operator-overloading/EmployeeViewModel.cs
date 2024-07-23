using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.casting_operator_overloading
{
    internal class EmployeeViewModel
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStamp { get; set; }

        public static explicit operator EmployeeViewModel(Employee employee)
        {
            string[]? Names = employee?.FullName?.Split(" ");
            return new EmployeeViewModel()
            {

                Email = employee?.Email ?? string.Empty,
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 1 ? Names[1] : string.Empty,


            };
            
        }
    }
}
