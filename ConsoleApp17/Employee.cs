using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17;

internal class Employee : IPerson
{
    public string Name { get ; set; }
    public int Age { get; set ; }
    public double Salary { get; set ; }
    private static int _Id;
    public int Id { get; }

    public Employee(string name,int age,double salary)
    {
        _Id++;
        Id= _Id;
        Name = name;
        Age = age;
        Salary = salary;
    }
    public string ShowInfo()
    {
        return $"Id:{Id} Name:{Name} Age:{Age} Salary:{Salary}";
    }
    public override string ToString()
    {
        return ShowInfo();
    }
}
