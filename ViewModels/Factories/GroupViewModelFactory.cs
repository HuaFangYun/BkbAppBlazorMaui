using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace ViewModels.Factories
{
    public class GroupViewModelFactory : IGroupViewModelFactory
    {
        public IGroupViewModel Create()
        {
            return new GroupViewModel();
        }
    }
}
