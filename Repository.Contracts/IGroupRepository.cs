using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IGroupRepository
    {
        Task<IGroupDomainModel> CreateGroupAsync(IGroupDomainModel grpDomainModel);

        Task<IGroupDomainModel> GetGroupByIdAsync(Guid grpId);

        Task UpdateGroupAsync(IGroupDomainModel grpDomainModel);

        Task DeleteGroupByIdAsync(Guid grpId);
    }
}
