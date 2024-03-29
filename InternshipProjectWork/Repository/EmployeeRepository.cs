using InternshipProjectWork.Data;
using InternshipProjectWork.Models;
using InternshipProjectWork.Models.Dto;

namespace InternshipProjectWork.Repository
{
    public class EmployeeRepository
    {
        private readonly ProjectDBContext projectDBContext;

        public EmployeeRepository(ProjectDBContext projectDBContext)
        {
            this.projectDBContext = projectDBContext;
        }


        public object GetAllEmployees()
        {
            return projectDBContext.Employees.ToList();
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
