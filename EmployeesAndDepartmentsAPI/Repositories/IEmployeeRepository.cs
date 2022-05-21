﻿using EmployeesAndDepartmentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesAndDepartmentsAPI.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackchanges);
        Task<Employee> GetEmployeeAsync(Guid Id, bool trackchanges);
        void CreateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
    }
}
