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
    }
}
