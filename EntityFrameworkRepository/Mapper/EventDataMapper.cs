using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using EntityFrameworkRepository.Mapper.Interfaces;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper
{
    public class EventDataMapper : IEventDataMapper
    {
        private readonly IEventDomainModelFactory _evtDomainModelFactory;
        private readonly IGroupDataMapper _grpDataMapper;

        public EventDataMapper(IEventDomainModelFactory evtDomainModelFactory, IGroupDataMapper grpDataMapper)
        {
            _evtDomainModelFactory = evtDomainModelFactory;
            _grpDataMapper = grpDataMapper;
        }

        public IEventDomainModel ToDomainModel(EventEntityModel evtEntityModel)
        {
            if (evtEntityModel == null)
                return null;

            var evtDomainModel = _evtDomainModelFactory.Create();
            evtDomainModel.Id = evtEntityModel.Id;
            evtDomainModel.Name = evtEntityModel.Name;
            evtDomainModel.Description = evtEntityModel.Description;
            evtDomainModel.Date = evtEntityModel.Date;
            evtDomainModel.Group = _grpDataMapper.ToDomainModel(evtEntityModel.Group);
            evtDomainModel.GroupId = evtEntityModel.GroupId;

            return evtDomainModel;
        }

        public EventEntityModel ToEntityModel(IEventDomainModel evtDomainModel)
        {
            if (evtDomainModel == null)
                return null;

            var evtEntityModel = new EventEntityModel();
            evtEntityModel.Id = evtDomainModel.Id;
            evtEntityModel.Name = evtDomainModel.Name;
            evtEntityModel.Description = evtDomainModel.Description;
            evtEntityModel.Date = evtDomainModel.Date;
            evtEntityModel.Group = _grpDataMapper.ToEntityModel(evtDomainModel.Group);
            evtEntityModel.GroupId = evtDomainModel.GroupId;

            return evtEntityModel;
        }
    }
}
