using DomainModels.Contracts;

namespace DomainModels
{
    public class GroupMemberDomainModel : IGroupMemberDomainModel
    {
        public Guid Id { get; set; }

        public IUserDomainModel User { get; set; }

        public IGroupDomainModel Group { get; set; }
    }
}
