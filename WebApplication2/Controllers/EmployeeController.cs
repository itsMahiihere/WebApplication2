using Microsoft.AspNetCore.Mvc;

using WebApplication2.Services;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public IActionResult Details(int id)
        {


            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }
    }
}

