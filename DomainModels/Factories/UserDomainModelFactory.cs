using DomainModels.Contracts;
using DomainModels.Contracts.Factories;

namespace DomainModels.Factories
{
    public class UserDomainModelFactory : IUserDomainModelFactory
    {
        public IUserDomainModel Create()
        {
            return new UserDomainModel();
        }
    }
}
