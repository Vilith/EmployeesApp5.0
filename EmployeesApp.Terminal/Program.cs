using EmployeesApp.Application.Employeen;
using EmployeesApp.Infrastructure.Persistance.Repositories;
namespace EmployeesApp.Terminal;

internal class Program
{
    static void Main(string[] args)
    {

        var employees = new EmployeeService(new EmployeeRepository()).GetAll();
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Email}");
        }

        Console.Write("Enter a valid number: ");
        try
        {
            if (int.TryParse(Console.ReadLine(), out int id) != null)
            {
                var emp = new EmployeeService(new EmployeeRepository()).GetById(id);
                Console.WriteLine($"Employee Name: {emp.Name}");

            }
            else
            {
                Console.WriteLine("Invalid number entered.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
