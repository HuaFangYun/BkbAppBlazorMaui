using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        Task<IUserDomainModel> CreateUserAsync(IUserDomainModel usrDomainModel);

        Task<IUserDomainModel> GetUserByIdAsync(Guid usrId);

        Task UpdateUserAsync(IUserDomainModel usrDomainModel);

        Task DeleteUserByIdAsync(Guid usrId);
    }
}
