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
    public class DepartmentController : ControllerBase
    {
        private readonly ProjectDBContext projectDBContext;
        DepartmentRepository departmentRepository;
        public DepartmentController(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
            departmentRepository = new DepartmentRepository(projectDBContext);  
        }

        [Authorize]
        [HttpPut]
        public object? UpdateDepartmentById(Department department)
        {
            return departmentRepository.UpdateDepartmentById(department);
        }


    }
}
