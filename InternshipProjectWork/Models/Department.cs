using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipProjectWork.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "nvarchar(30)")]
        public string Name { get; set; }
    }
}
