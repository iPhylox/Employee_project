using System.ComponentModel.DataAnnotations;

namespace Employee_project.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public string? Department { get; set; }
        public decimal BaseSalary { get; set; }
        public string? Position { get; set; }
    }

}
