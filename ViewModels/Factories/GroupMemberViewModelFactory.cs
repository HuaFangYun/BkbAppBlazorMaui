using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace ViewModels.Factories
{
    public class GroupMemberViewModelFactory : IGroupMemberViewModelFactory
    {
        public IGroupMemberViewModel Create()
        {
            return new GroupMemberViewModel();
        }
    }
}
