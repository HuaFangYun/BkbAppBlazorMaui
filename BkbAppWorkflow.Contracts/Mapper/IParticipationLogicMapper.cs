using DomainModels.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IParticipationLogicMapper
    {
        IParticipationDomainModel ToDomainModel(IParticipationViewModel ptpViewModel);

        IParticipationViewModel ToViewModel(IParticipationDomainModel ptpDomainModel);
    }
}
