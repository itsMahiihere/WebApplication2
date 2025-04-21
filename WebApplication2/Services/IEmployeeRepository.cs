using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
