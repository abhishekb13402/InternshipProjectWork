using InternshipProjectWork.Data;
using InternshipProjectWork.Models;
using InternshipProjectWork.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace InternshipProjectWork.Repository
{
    public class UserRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public UserRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }


        public object GetAllUsername()
        {
            //return projectDBContext.Logindetails.ToList();
            var usernames = projectDBContext.Logindetails.Select(ld => ld.Username).ToList();
            return usernames;


        }
    }
}
