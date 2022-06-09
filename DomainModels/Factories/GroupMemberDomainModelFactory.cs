using DomainModels.Contracts;
using DomainModels.Contracts.Factories;

namespace DomainModels.Factories
{
    public class GroupMemberDomainModelFactory : IGroupMemberDomainModelFactory
    {
        public IGroupMemberDomainModel Create()
        {
            return new GroupMemberDomainModel();
        }
    }
}
