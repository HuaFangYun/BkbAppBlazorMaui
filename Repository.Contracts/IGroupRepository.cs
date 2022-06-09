using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IGroupRepository
    {
        IGroupDomainModel CreateGroup(IGroupDomainModel grpDomainModel);

        IGroupDomainModel GetGroupById(Guid grpId);

        void UpdateGroup(IGroupDomainModel grpDomainModel);

        void DeleteGroupById(Guid grpId);
    }
}
