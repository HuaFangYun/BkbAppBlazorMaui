using DomainModels.Contracts;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper.Interfaces
{
    public interface IGroupMemberDataMapper
    {
        GroupMemberEntityModel ToEntityModel(IGroupMemberDomainModel grpMmbDomainModel);

        IGroupMemberDomainModel ToDomainModel(GroupMemberEntityModel grpMmbEntityModel);
    }
}
