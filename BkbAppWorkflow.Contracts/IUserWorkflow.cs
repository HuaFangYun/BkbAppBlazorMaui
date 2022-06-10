using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IUserWorkflow
    {
        Task<IUserViewModel> CreateUserAsync(IUserViewModel usrViewModel);

        Task<IUserViewModel> GetUserByIdAsync(Guid usrId);

        Task UpdateUserAsync(IUserViewModel usrViewModel);

        Task DeleteUserByIdAsync(Guid usrId);
    }
}
