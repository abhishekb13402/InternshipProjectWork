using InternshipProjectWork.Data;
using InternshipProjectWork.Models;
using InternshipProjectWork.Models.Dto;

namespace InternshipProjectWork.Repository
{
    public class UserRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public UserRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }


        public List<logindetails> GetAllUsername()
        {
            return projectDBContext.Logindetails.ToList();
            //return projectDBContext.Logindetails.Select(x => x.Username).ToList();

        }
    }
}
