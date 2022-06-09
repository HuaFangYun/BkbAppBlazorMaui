using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IGroupMemberWorkflow
    {
        IGroupMemberViewModel CreateGroupMember(IGroupMemberViewModel grpMmbViewModel);

        IGroupMemberViewModel GetGroupMemberById(Guid grpMmbId);

        void UpdateGroupMember(IGroupMemberViewModel grpMmbViewModel);

        void DeleteGroupMemberById(Guid grpMmbId);
    }
}
