using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using EntityFrameworkRepository.Mapper.Interfaces;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper
{
    public class ParticipationDataMapper : IParticipationDataMapper
    {
        private readonly IParticipationDomainModelFactory _ptpDomainModelFactory;
        private readonly IUserDataMapper _usrDataMapper;
        private readonly IEventDataMapper _evtDataMapper;

        public ParticipationDataMapper(IParticipationDomainModelFactory ptpDomainModelFactory, IUserDataMapper usrDataMapper, IEventDataMapper evtDataMapper)
        {
            _ptpDomainModelFactory = ptpDomainModelFactory;
            _usrDataMapper = usrDataMapper;
            _evtDataMapper = evtDataMapper;
        }

        public IParticipationDomainModel ToDomainModel(ParticipationEntityModel ptpEntityModel)
        {
            if (ptpEntityModel == null)
                return null;

            var ptpDomainModel = _ptpDomainModelFactory.Create();
            ptpDomainModel.Id = ptpEntityModel.Id;
            ptpDomainModel.Participate = ptpEntityModel.Participate;
            ptpDomainModel.Reason = ptpEntityModel.Reason;
            ptpDomainModel.User = _usrDataMapper.ToDomainModel(ptpEntityModel.User);
            ptpDomainModel.UserId = ptpEntityModel.UserId;
            ptpDomainModel.Event = _evtDataMapper.ToDomainModel(ptpEntityModel.Event);
            ptpDomainModel.EventId = ptpEntityModel.EventId;

            return ptpDomainModel;

        }

        public ParticipationEntityModel ToEntityModel(IParticipationDomainModel ptpDomainModel)
        {
            if (ptpDomainModel == null)
                return null;

            var ptpEntityModel = new ParticipationEntityModel();
            ptpEntityModel.Id = ptpDomainModel.Id;
            ptpEntityModel.Participate = ptpDomainModel.Participate;
            ptpEntityModel.Reason = ptpDomainModel.Reason;
            ptpEntityModel.User = _usrDataMapper.ToEntityModel(ptpDomainModel.User);
            ptpEntityModel.UserId = ptpDomainModel.UserId;
            ptpEntityModel.Event = _evtDataMapper.ToEntityModel(ptpDomainModel.Event);
            ptpEntityModel.EventId = ptpDomainModel.EventId;

            return ptpEntityModel;
        }
    }
}
