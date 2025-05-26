using EmployeesApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application.Employeen
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee GetById(int id);

    }
}
