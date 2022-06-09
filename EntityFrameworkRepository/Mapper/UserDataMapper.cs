using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using EntityFrameworkRepository.Mapper.Interfaces;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper
{
    public class UserDataMapper : IUserDataMapper
    {
        private readonly IUserDomainModelFactory _usrDomainModelFactory;

        public UserDataMapper(IUserDomainModelFactory usrDomainModelFactory)
        {
            _usrDomainModelFactory = usrDomainModelFactory;
        }

        public IUserDomainModel ToDomainModel(UserEntityModel usrEntityModel)
        {
            if (usrEntityModel == null)
                return null;

            var usrDomainModel = _usrDomainModelFactory.Create();
            usrDomainModel.Id = usrEntityModel.Id;
            usrDomainModel.Name = usrEntityModel.Name;
            usrDomainModel.Email = usrEntityModel.Email;

            return usrDomainModel;
        }

        public UserEntityModel ToEntityModel(IUserDomainModel usrDomainModel)
        {
            if (usrDomainModel == null)
                return null;

            var usrEntityModel = new UserEntityModel();
            usrEntityModel.Id = usrDomainModel.Id;
            usrEntityModel.Name = usrDomainModel.Name;
            usrEntityModel.Email = usrDomainModel.Email;

            return usrEntityModel;
        }
    }
}
