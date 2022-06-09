using DomainModels.Contracts;

namespace DomainModels
{
    public class GroupMemberDomainModel : IGroupMemberDomainModel
    {
        public Guid Id { get; set; }

        public virtual IUserDomainModel User { get; set; }

        public Guid? UserId { get; set; }

        public virtual IGroupDomainModel Group { get; set; }

        public Guid? GroupId { get; set; }
    }
}
