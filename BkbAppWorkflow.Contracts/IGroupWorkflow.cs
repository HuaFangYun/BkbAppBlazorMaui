using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IGroupWorkflow
    {
        Task<IGroupViewModel> CreateGroupAsync(IGroupViewModel grpViewModel);

        Task<IGroupViewModel> GetGroupByIdAsync(Guid grpId);

        Task UpdateGroupAsync(IGroupViewModel grpViewModel);

        Task DeleteGroupByIdAsync(Guid grpId);
    }
}
