using DomainModels.Contracts;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper.Interfaces
{
    public interface IParticipationDataMapper
    {
        ParticipationEntityModel ToEntityModel(IParticipationDomainModel ptpDomainModel);

        IParticipationDomainModel ToDomainModel(ParticipationEntityModel ptpEntityModel);
    }
}
