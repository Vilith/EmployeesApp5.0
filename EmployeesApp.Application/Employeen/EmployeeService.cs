using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employeen;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public void Add(Employee employee) => employeeRepository.Add(employee);


    public Employee[] GetAll() => [.. employeeRepository.GetAll()];

    public Employee GetById(int id)
    {
        try
        {
            var employee = employeeRepository.GetById(id);
            return employee;
        }
        catch (Exception ex)
        {

            throw new ArgumentException($"Employee with id {id} not found. {ex.Message}");
        }
    }

    public bool CheckIsVIP(Employee employee) =>
        employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
}