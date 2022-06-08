using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.Models
{
    [Table("Groups")]
    public class GroupEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
