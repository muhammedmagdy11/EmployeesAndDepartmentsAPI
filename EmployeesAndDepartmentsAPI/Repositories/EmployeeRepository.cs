using EmployeesAndDepartmentsAPI.Context;
using EmployeesAndDepartmentsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesAndDepartmentsAPI.Repositories
{
    public class EmployeeRepository:RepositoryBase<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(ProjectContext projectContext):base(projectContext)
        {

        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackchanges)
        {
            return await FindAll(trackchanges).ToListAsync();
        }
        public async Task<Employee> GetEmployeeAsync(Guid Id, bool trackchanges)
        {
            return await FindByCondition(e => e.Id.Equals(Id), trackchanges).SingleOrDefaultAsync();
        }
        public void CreateEmployee(Employee employee)
        {
            if (employee != null)
                 Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            if (employee != null)
                Delete(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee != null)
                Update(employee);
        }
    }
}
