using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        IUserDomainModel CreateUserAsync(IUserDomainModel usrDomainModel);

        IUserDomainModel GetUserByIdAsync(Guid usrId);

        Task UpdateUserAsync(IUserDomainModel usrDomainModel);

        Task DeleteUserByIdAsync(Guid usrId);
    }
}
