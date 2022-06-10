using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IGroupMemberWorkflow
    {
        Task<IGroupMemberViewModel> CreateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel);

        Task<IGroupMemberViewModel> GetGroupMemberByIdAsync(Guid grpMmbId);

        Task UpdateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel);

        Task DeleteGroupMemberByIdAsync(Guid grpMmbId);
    }
}
