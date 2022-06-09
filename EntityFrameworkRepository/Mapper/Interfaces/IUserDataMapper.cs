using DomainModels.Contracts;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper.Interfaces
{
    public interface IUserDataMapper
    {
        UserEntityModel ToEntityModel(IUserDomainModel usrDomainModel);

        IUserDomainModel ToDomainModel(UserEntityModel usrEntityModel);
    }
}
