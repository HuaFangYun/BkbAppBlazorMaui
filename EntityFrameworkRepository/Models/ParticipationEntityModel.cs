using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.Models
{
    [Table("Participations")]
    public class ParticipationEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public UserEntityModel User { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }

        public EventEntityModel Event { get; set; }
    }
}
