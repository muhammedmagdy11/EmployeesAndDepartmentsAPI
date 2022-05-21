using System.Threading.Tasks;
using EmployeesAndDepartmentsAPI.Context;

namespace EmployeesAndDepartmentsAPI.Repositories
{
    public class RepositoryManager: IRepositoryManager
    {
        private IEmployeeRepository _EmployeeRepository;
        private ProjectContext _ProjectContext;

        public RepositoryManager(ProjectContext ProjectContext)
        {
            _ProjectContext = ProjectContext;
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_EmployeeRepository == null)
                    _EmployeeRepository = new EmployeeRepository(_ProjectContext);
                return _EmployeeRepository;
            }
        }

        public Task SaveAsync()
        {
            return _ProjectContext.SaveChangesAsync();

        }
    }
}
