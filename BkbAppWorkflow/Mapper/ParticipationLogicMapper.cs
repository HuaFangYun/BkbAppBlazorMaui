using BkbAppWorkflow.Contracts.Mapper;
using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class ParticipationLogicMapper : IParticipationLogicMapper
    {
        private readonly IParticipationDomainModelFactory _ptpDomainModelFactory;
        private readonly IParticipationViewModelFactory _ptpViewModelFactory;
        private readonly IUserLogicMapper _usrLogicMapper;
        private readonly IEventLogicMapper _evtLogicMapper;

        public ParticipationLogicMapper(IParticipationDomainModelFactory ptpDomainModelFactory, IParticipationViewModelFactory ptpViewModelFactory, IUserLogicMapper usrLogicMapper, IEventLogicMapper evtLogicMapper)
        {
            _ptpDomainModelFactory = ptpDomainModelFactory;
            _ptpViewModelFactory = ptpViewModelFactory;
            _usrLogicMapper = usrLogicMapper;
            _evtLogicMapper = evtLogicMapper;
        }

        public IParticipationDomainModel ToDomainModel(IParticipationViewModel ptpViewModel)
        {
            if (ptpViewModel == null)
                return null;

            var ptpDomainModel = _ptpDomainModelFactory.Create();
            ptpDomainModel.Id = ptpViewModel.Id;
            ptpDomainModel.Participate = ptpViewModel.Participate;
            ptpDomainModel.Reason = ptpViewModel.Reason;
            ptpDomainModel.User = _usrLogicMapper.ToDomainModel(ptpViewModel.User);
            ptpDomainModel.Event = _evtLogicMapper.ToDomainModel(ptpViewModel.Event);

            return ptpDomainModel;
        }

        public IParticipationViewModel ToViewModel(IParticipationDomainModel ptpDomainModel)
        {
            if (ptpDomainModel == null)
                return null;

            var ptpViewModel = _ptpViewModelFactory.Create();
            ptpViewModel.Id = ptpDomainModel.Id;
            ptpViewModel.Participate = ptpDomainModel.Participate;
            ptpViewModel.Reason = ptpDomainModel.Reason;
            ptpViewModel.User = _usrLogicMapper.ToViewModel(ptpDomainModel.User);
            ptpViewModel.Event = _evtLogicMapper.ToViewModel(ptpDomainModel.Event);

            return ptpViewModel;
        }
    }
}
