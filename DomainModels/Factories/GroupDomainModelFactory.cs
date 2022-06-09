using DomainModels.Contracts;
using DomainModels.Contracts.Factories;

namespace DomainModels.Factories
{
    public class GroupDomainModelFactory : IGroupDomainModelFactory
    {
        public IGroupDomainModel Create()
        {
            return new GroupDomainModel();
        }
    }
}
