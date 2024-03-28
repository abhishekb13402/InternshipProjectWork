using InternshipProjectWork.Data;
using InternshipProjectWork.Models.Dto;

namespace InternshipProjectWork.Repository
{
    public class LoginRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public LoginRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }

        public bool LoginApi(AuthenticationDto authenticationDto)
        {
            int rowcount = projectDBContext.Logindetails.Where(i => i.Username == authenticationDto.username && i.Password == authenticationDto.password).Count();
            if (rowcount == 0)
                return false;
            else
            {
                return true;
            }
        }




    }
}
