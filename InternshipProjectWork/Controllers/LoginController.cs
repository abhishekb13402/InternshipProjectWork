using InternshipProjectWork.Data;
using InternshipProjectWork.Models.Dto;
using InternshipProjectWork.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InternshipProjectWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ProjectDBContext projectDBContext;
        private IConfiguration _config;
        LoginRepository _loginRepository;
        public LoginController(ProjectDBContext projectDBContext,IConfiguration configuration)
        {
            this.projectDBContext = projectDBContext;
            _loginRepository = new LoginRepository(projectDBContext);
            _config =configuration;
          
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public object LoginApi(AuthenticationDto authenticationDto)
        {
            bool isValid = _loginRepository.LoginApi(authenticationDto);
            if (isValid)
            {
                return generateToken(authenticationDto.username,authenticationDto.password);
            }
            else
            {
                return new Exception("Invalid user name and password");
            }
        }

        
        private object generateToken(string username, string password)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,username),
                new Claim(ClaimTypes.NameIdentifier,password)
            };
            var token = new JwtSecurityToken(this._config["Jwt:Issuer"],
                this._config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
