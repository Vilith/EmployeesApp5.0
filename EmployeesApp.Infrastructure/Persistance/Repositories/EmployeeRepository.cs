﻿using EmployeesApp.Application.Employeen;
using EmployeesApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Anders Hejlsberg",
                Email = "Anders.Hejlsberg@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Kathleen Dollard",
                Email = "k.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Mads Torgersen",
                Email = "Admin.Torgersen@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Scott Hanselman",
                Email = "s.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Jon Skeet",
                Email = "j.s@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }


        // Collection expression syntax, introduced in C# 12.
        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];

        ////Classic C# syntax for GetAll()
        //public Employee[] GetAll()
        //{
        //    return employees
        //        .OrderBy(e => e.Name)
        //        .ToArray();
        //}

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);
    }
}
