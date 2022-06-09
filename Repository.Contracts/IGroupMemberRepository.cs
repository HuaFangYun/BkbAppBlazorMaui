using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IGroupMemberRepository
    {
        IGroupMemberDomainModel CreateGroupMember(IGroupMemberDomainModel grpMmbDomainModel);

        IGroupMemberDomainModel GetGroupMemberById(Guid grpMmbId);

        void UpdateGroupMember(IGroupMemberDomainModel grpMmbDomainModel);

        void DeleteGroupMemberById(Guid grpMmbId);
    }
}
