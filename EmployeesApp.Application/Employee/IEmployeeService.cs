using EmployeesApp.Domain.Employee;

namespace EmployeesApp.Application.Employee
{
    public interface IEmployeeService
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}
