using BkbAppWorkflow.Contracts.Mapper;
using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class GroupLogicMapper : IGroupLogicMapper
    {
        private readonly IGroupDomainModelFactory _grpDomainModelFactory;
        private readonly IGroupViewModelFactory _grpViewModelFactory;

        public GroupLogicMapper(IGroupDomainModelFactory grpDomainModelFactory, IGroupViewModelFactory grpViewModelFactory)
        {
            _grpDomainModelFactory = grpDomainModelFactory;
            _grpViewModelFactory = grpViewModelFactory;
        }

        public IGroupDomainModel ToDomainModel(IGroupViewModel grpViewModel)
        {
            if (grpViewModel == null)
                return null;

            var grpDomainModel = _grpDomainModelFactory.Create();
            grpDomainModel.Id = grpViewModel.Id;
            grpDomainModel.Name = grpViewModel.Name;

            return grpDomainModel;
        }

        public IGroupViewModel ToViewModel(IGroupDomainModel grpDomainModel)
        {
            if (grpDomainModel == null)
                return null;

            var grpViewModel = _grpViewModelFactory.Create();
            grpViewModel.Id = grpDomainModel.Id;
            grpViewModel.Name = grpDomainModel.Name;

            return grpViewModel;
        }
    }
}
