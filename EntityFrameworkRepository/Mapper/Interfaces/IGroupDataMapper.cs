using DomainModels.Contracts;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper.Interfaces
{
    public interface IGroupDataMapper
    {
        GroupEntityModel ToEntityModel(IGroupDomainModel grpDomainModel);

        IGroupDomainModel ToDomainModel(GroupEntityModel grpEntityModel);
    }
}
