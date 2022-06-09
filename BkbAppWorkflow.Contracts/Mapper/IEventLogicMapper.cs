using DomainModels.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IEventLogicMapper
    {
        IEventDomainModel ToDomainModel(IEventViewModel evtViewModel);

        IEventViewModel ToViewModel(IEventDomainModel evtDomainModel);
    }
}
