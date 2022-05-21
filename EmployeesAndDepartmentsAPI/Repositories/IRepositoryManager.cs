
using System.Threading.Tasks;

namespace EmployeesAndDepartmentsAPI.Repositories
{
    public interface IRepositoryManager
    {
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
