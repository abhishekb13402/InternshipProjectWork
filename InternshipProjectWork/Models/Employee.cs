using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipProjectWork.Models
{
    public class Employee
    {
        [Key]
        [Column("Id",TypeName = "nvarchar(10)")]
        public string Id { get; set; }


        [Column("Name", TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        
        
        [Column("DOJ",TypeName = "DateTime2")]
        public DateTime DateOfJoining { get; set; }


        [Column("DepartmentID")]
        public int DepartmentID { get; set; }


        [EmailAddress]
        [Column("Email", TypeName = "nvarchar(30)")]
        public string Email { get; set; }
    }
}
