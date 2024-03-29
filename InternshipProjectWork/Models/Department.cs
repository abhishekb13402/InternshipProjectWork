using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipProjectWork.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Column("DeptName", TypeName = "nvarchar(30)")]
        public string DeptName { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
