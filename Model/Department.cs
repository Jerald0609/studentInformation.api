using System.ComponentModel.DataAnnotations;

namespace StudentInformation.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Office { get; set; }
    }
}
