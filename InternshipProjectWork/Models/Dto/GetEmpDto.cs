namespace InternshipProjectWork.Models.Dto
{
    public class GetEmpDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }

        public int DepartmentID { get; set; }
        public string Email { get; set; }

        public string DeptName { get; set; }

    }
}
