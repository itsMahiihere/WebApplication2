using System.Linq;

using WebApplication2.Models;
using WebApplication2.Services;
using WebApplication2;

namespace WebApplication1.Services
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly Appdbcontext context;
        public SQLEmployeeRepository(Appdbcontext context)
        {
            this.context = context;
        }


        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;

        }

        public Employee GetEmployee(int id)
        {

            // context.Employee.SingleOrDefault(data => data.Id == Id)
            return context.Employees.Find(id);


        }
    }
}
