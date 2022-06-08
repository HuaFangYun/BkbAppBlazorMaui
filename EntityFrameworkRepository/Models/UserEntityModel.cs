using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.Models
{
    [Table("Users")]
    public class UserEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
