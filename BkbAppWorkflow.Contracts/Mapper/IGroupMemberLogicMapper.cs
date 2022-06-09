using DomainModels.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IGroupMemberLogicMapper
    {
        IGroupMemberDomainModel ToDomainModel(IGroupMemberViewModel grpMmbViewModel);

        IGroupMemberViewModel ToViewModel(IGroupMemberDomainModel grpMmbDomainModel);
    }
}
