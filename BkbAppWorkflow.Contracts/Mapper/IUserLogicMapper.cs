using DomainModels.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IUserLogicMapper
    {
        IUserDomainModel ToDomainModel(IUserViewModel usrViewModel);

        IUserViewModel ToViewModel(IUserDomainModel usrDomainModel);
    }
}
