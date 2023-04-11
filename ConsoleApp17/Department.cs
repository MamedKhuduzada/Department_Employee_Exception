using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17;

internal class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    Employee[] employees = new Employee[0];
    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        
    }

    public void AddEmployee(Employee employee)
    {
        if (EmployeeLimit > employees.Length)
        {
        Array.Resize(ref employees, employees.Length+1);
        employees[employees.Length-1] = employee;
        }
        else
        {
            throw new CapacityLimitException("Artiq isciye ehtiyacimiz yoxdur");
        }
            
        
    }
}
