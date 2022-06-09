using BkbAppWorkflow.Contracts.Mapper;
using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class UserLogicMapper : IUserLogicMapper
    {
        private readonly IUserDomainModelFactory _usrDomainModelFactory;
        private readonly IUserViewModelFactory _usrViewModelFactory;

        public UserLogicMapper(IUserDomainModelFactory usrDomainModelFactory, IUserViewModelFactory usrViewModelFactory)
        {
            _usrDomainModelFactory = usrDomainModelFactory;
            _usrViewModelFactory = usrViewModelFactory;
        }

        public IUserDomainModel ToDomainModel(IUserViewModel usrViewModel)
        {
            if (usrViewModel == null)
                return null;

            var usrDomainModel = _usrDomainModelFactory.Create();
            usrDomainModel.Id = usrViewModel.Id;
            usrDomainModel.Name = usrViewModel.Name;
            usrDomainModel.Email = usrViewModel.Email;

            return usrDomainModel;
        }

        public IUserViewModel ToViewModel(IUserDomainModel usrDomainModel)
        {
            if (usrDomainModel == null)
                return null;

            var usrViewModel = _usrViewModelFactory.Create();
            usrViewModel.Id = usrDomainModel.Id;
            usrViewModel.Name = usrDomainModel.Name;
            usrViewModel.Email = usrDomainModel.Email;

            return usrViewModel;
        }
    }
}
