using InternshipProjectWork.Data;
using InternshipProjectWork.Models;

namespace InternshipProjectWork.Repository
{
    public class DepartmentRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public DepartmentRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }

        internal object? UpdateDepartmentById(Department department)
        {
            var existdept = projectDBContext.Departments.Find(department.DepartmentID);
            if (existdept == null)
            {
                return null;
            }
            else
            {
                existdept.DeptName = department.DeptName;

                projectDBContext.SaveChanges();
                return department;
            }
        }

    }
}
