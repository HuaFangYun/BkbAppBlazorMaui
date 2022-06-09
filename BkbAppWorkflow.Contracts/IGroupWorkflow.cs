using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IGroupWorkflow
    {
        IGroupViewModel CreateGroup(IGroupViewModel grpViewModel);

        IGroupViewModel GetGroupById(Guid grpId);

        void UpdateGroup(IGroupViewModel grpViewModel);

        void DeleteGroupById(Guid grpId);
    }
}
