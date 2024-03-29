using InternshipProjectWork.Data;
using InternshipProjectWork.Models;
using InternshipProjectWork.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace InternshipProjectWork.Repository
{
    public class EmployeeRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public EmployeeRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }


        public List<GetEmpDto> GetAllEmployees()
        {
            //    return projectDBContext.Employees
            //        //.Include(x=>x.Department.Name)
            //        .ToList();

            var result = (from e in projectDBContext.Employees
                          join d in projectDBContext.Departments
                          on e.DepartmentID equals d.DepartmentID
                          select new GetEmpDto{
                                Id = e.Id,
                                Name = e.Name,
                                DateOfJoining = e.DateOfJoining,
                                DepartmentID = e.DepartmentID,
                                Email = e.Email,
                                DeptName = d.DeptName,

                          }).ToList();
            return result;
        
        }

        public Employee? AddEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            employee.Id = (string)GenerateCustomID(employee.Name, employee.DateOfJoining);

            projectDBContext.Employees.Add(employee);
            projectDBContext.SaveChanges();
            return employee;
        }

        private static string GenerateCustomID(string name, DateTime doj)
        {
            string initials = name.Substring(0, Math.Min(name.Length, 2));

            string year = doj.Year.ToString(); 
            string randomDigits = new Random().Next(1000, 9999).ToString();

            return $"{initials.ToUpper()}{year}{randomDigits}";
        }



    }
}
