using DomainModels.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IGroupLogicMapper
    {
        IGroupDomainModel ToDomainModel(IGroupViewModel grpViewModel);

        IGroupViewModel ToViewModel(IGroupDomainModel grpDomainModel);
    }
}
