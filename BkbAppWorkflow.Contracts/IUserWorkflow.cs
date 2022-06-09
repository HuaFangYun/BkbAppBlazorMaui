using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IUserWorkflow
    {
        IUserViewModel CreateUser(IUserViewModel usrViewModel);

        IUserViewModel GetUserById(Guid usrId);

        void UpdateUser(IUserViewModel usrViewModel);

        void DeleteUserById(Guid usrId);
    }
}
