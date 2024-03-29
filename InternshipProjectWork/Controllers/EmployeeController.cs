using InternshipProjectWork.Data;
using InternshipProjectWork.Models;
using InternshipProjectWork.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProjectWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ProjectDBContext projectDBContext;
        EmployeeRepository employeeRepository;

        public EmployeeController(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
            employeeRepository = new EmployeeRepository(projectDBContext);
        }

        [Authorize]
        [HttpGet]
        public object GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        [Authorize]
        [HttpPost]
        public object? AddEmployee(Employee employee)
        {
            return employeeRepository.AddEmployee(employee);
        }


    }
}
