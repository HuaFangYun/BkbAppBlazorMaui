using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.Models
{
    [Table("Events")]
    public class EventEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(Group))]
        public Guid? GroupId { get; set; }

        public virtual GroupEntityModel Group { get; set; }
    }
}
