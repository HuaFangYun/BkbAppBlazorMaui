using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace ViewModels.Factories
{
    public class UserViewModelFactory : IUserViewModelFactory
    {
        public IUserViewModel Create()
        {
            return new UserViewModel();
        }
    }
}
