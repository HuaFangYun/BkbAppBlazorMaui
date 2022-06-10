using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using Repository.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class UserWorkflow : IUserWorkflow
    {
        private readonly IUserLogicMapper _usrLogicMapper;
        private readonly IUserRepository _usrRepository;

        public UserWorkflow(IUserLogicMapper usrLogicMapper, IUserRepository usrRepository)
        {
            _usrLogicMapper = usrLogicMapper;
            _usrRepository = usrRepository;
        }

        public async Task<IUserViewModel> CreateUserAsync(IUserViewModel usrViewModel)
        {
            var usrDomainModel = await _usrRepository.CreateUserAsync(_usrLogicMapper.ToDomainModel(usrViewModel));
            return _usrLogicMapper.ToViewModel(usrDomainModel);
        }

        public async Task<IUserViewModel> GetUserByIdAsync(Guid usrId)
        {
            var usrDomainModel = await _usrRepository.GetUserByIdAsync(usrId);
            return _usrLogicMapper.ToViewModel(usrDomainModel);
        }

        public async Task UpdateUserAsync(IUserViewModel usrViewModel)
        {
            await _usrRepository.UpdateUserAsync(_usrLogicMapper.ToDomainModel(usrViewModel));
        }

        public async Task DeleteUserByIdAsync(Guid usrId)
        {
            await _usrRepository.DeleteUserByIdAsync(usrId);
        }
    }
}
