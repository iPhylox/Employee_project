using System.ComponentModel.DataAnnotations;

namespace Employee_project.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; }


    }
}
