using System.ComponentModel.DataAnnotations;

namespace SoftwareII.Models
{
    public class Stakeholder
    {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public string Company { get; set; }
            [Required]
            public int Code { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        
    }
}
