using ConsoleApp17;

internal class Program
{
    private static void Main(string[] args)
    {
		Employee epm1 = new Employee("Melik", 11, 2);
		Employee epm2 = new Employee("Ulvi", 12, 1.5);
		Employee epm3 = new Employee("Ulvi", 12, 1.5);
        Department dp1 = new Department("Insaat",3);
		
        try
		{
		dp1.AddEmployee(epm1);
		dp1.AddEmployee(epm2);
		dp1.AddEmployee(epm3);
        }
		catch (CapacityLimitException ex)
		{
			Console.WriteLine(ex.Message);
		}
    }
}