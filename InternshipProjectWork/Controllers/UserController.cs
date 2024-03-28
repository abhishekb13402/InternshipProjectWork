using InternshipProjectWork.Data;
using InternshipProjectWork.Models.Dto;
using InternshipProjectWork.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipProjectWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ProjectDBContext projectDBContext;
        private IConfiguration _config;
        UserRepository _UserRepository;

        public UserController(ProjectDBContext projectDBContext,IConfiguration configuration)
        {
            this.projectDBContext = projectDBContext;
            _UserRepository = new UserRepository(projectDBContext);
            _config = configuration;
        }

        [Authorize]
        [HttpGet("GetAll")]
        public object GetAllUsername()
        {
            return _UserRepository.GetAllUsername();
        }




    }
}
