using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employeen;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public void Add(Employee employee) => employeeRepository.Add(employee);


    public Employee[] GetAll() => [.. employeeRepository.GetAll()];

    public Employee GetById(int id) => employeeRepository.GetById(id);

    public bool CheckIsVIP(Employee employee) =>
        employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
}