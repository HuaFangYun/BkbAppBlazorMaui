using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IGroupMemberRepository
    {
        Task<IGroupMemberDomainModel> CreateGroupMemberAsync(IGroupMemberDomainModel grpMmbDomainModel);

        Task<IGroupMemberDomainModel> GetGroupMemberByIdAsync(Guid grpMmbId);

        Task UpdateGroupMemberAsync(IGroupMemberDomainModel grpMmbDomainModel);

        Task DeleteGroupMemberByIdAsync(Guid grpMmbId);
    }
}
