using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using Repository.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class ParticipationWorkflow : IParticipationWorkflow
    {
        private readonly IParticipationLogicMapper _ptpLogicMapper;
        private readonly IParticipationRepository _ptpRepository;

        public ParticipationWorkflow(IParticipationLogicMapper ptpLogicMapper, IParticipationRepository ptpRepository)
        {
            _ptpLogicMapper = ptpLogicMapper;
            _ptpRepository = ptpRepository;
        }

        public async Task<IParticipationViewModel> CreateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            var ptpDomainModel = await _ptpRepository.CreateParticipationAsync(_ptpLogicMapper.ToDomainModel(ptpViewModel));
            return _ptpLogicMapper.ToViewModel(ptpDomainModel);
        }

        public async Task<IParticipationViewModel> GetParticipationByIdAsync(Guid ptpId)
        {
            var ptpDomainModel = await _ptpRepository.GetParticipationByIdAsync(ptpId);
            return _ptpLogicMapper.ToViewModel(ptpDomainModel);
        }

        public async Task UpdateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            await _ptpRepository.UpdateParticipationAsync(_ptpLogicMapper.ToDomainModel(ptpViewModel));
        }

        public async Task DeleteParticipationByIdAsync(Guid ptpId)
        {
            await _ptpRepository.DeleteParticipationByIdAsync(ptpId);
        }
    }
}
