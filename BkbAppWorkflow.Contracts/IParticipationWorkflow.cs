using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IParticipationWorkflow
    {
        Task<IParticipationViewModel> CreateParticipationAsync(IParticipationViewModel ptpViewModel);

        Task<IParticipationViewModel> GetParticipationByIdAsync(Guid ptpId);

        Task UpdateParticipationAsync(IParticipationViewModel ptpViewModel);

        Task DeleteParticipationByIdAsync(Guid ptpId);
    }
}
