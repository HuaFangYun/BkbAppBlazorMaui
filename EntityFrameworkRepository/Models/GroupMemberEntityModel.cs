using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.Models
{
    [Table("GroupMembers")]
    public class GroupMemberEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public UserEntityModel User { get; set; }

        [ForeignKey(nameof(Group))]
        public Guid? GroupId { get; set; }

        public GroupEntityModel Group { get; set; }
    }
}
