using System.ComponentModel.DataAnnotations;

namespace SoftwareII.Models
{
    public class Empleado
    {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            public int Area { get; set; }
            [Required]
            public int Code { get; set; }
            [Required]
            [Phone]
            public string Phone { get; set; }
            [Required]
            public int Rol { get; set; }
    }
}



