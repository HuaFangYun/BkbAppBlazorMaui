using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IParticipationWorkflow
    {
        IParticipationViewModel CreateParticipation(IParticipationViewModel ptpViewModel);

        IParticipationViewModel GetParticipationById(Guid ptpId);

        void UpdateParticipation(IParticipationViewModel ptpViewModel);

        void DeleteParticipationById(Guid ptpId);
    }
}
